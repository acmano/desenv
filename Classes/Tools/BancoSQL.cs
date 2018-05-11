﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace Lor0138.Classes.Tools
{
  public class Msde
  {
    private readonly SqlConnection  _connSql;
    private readonly String         _connectionString;
    private          String         _mensagemErro;
    private          int            _identity;
    private          SqlCommand     _cmdSql;
    private          SqlDataReader  _dtrSql;
    private          Boolean        _transacao;
    private          SqlTransaction _sqlTran;
    private          Boolean        _conectado;

    public bool Conectado
    {
      get { return _conectado; }
      set { _conectado = value; }
    }

    public string MensagemErro
    {
      get { return _mensagemErro; }
      set { _mensagemErro = value; }
    }

    public int Identity
    {
      get { return _identity; }
      set { _identity = value; }
    }

    public Msde ( AcessoSql acessoSql )
    {
      var connectionString = new StringBuilder( );
      connectionString.AppendFormat(@"data source={0};user id={1};password={2}", acessoSql.Server, acessoSql.UserName,acessoSql.Password);
      MensagemErro = "";
      _connectionString = connectionString.ToString();
      _connSql = new SqlConnection ( );
      Open ( );
    }

    public Boolean Open ( )
    {
      Boolean retorno = false;
      try
      {
        _connSql.ConnectionString = _connectionString;
        _connSql.Open ( );
        _conectado = true;
        MensagemErro = "";
        retorno = true;
      }
      catch ( Exception erro )
      {
        MensagemErro = erro.Message;
        _conectado = false;
      }
      return retorno;
    }

    public void BeginTransaction ( )
    {
      try
      {
        _sqlTran = _connSql.BeginTransaction ( );
        MensagemErro = "";
        _transacao = true;
      }
      catch ( Exception erro )
      {
        MensagemErro = erro.Message;
        _sqlTran = null;
        _transacao = false;
      }
    }

    public void Commit ( )
    {
      try
      {
        _sqlTran.Commit ( );
        _transacao = false;
        MensagemErro = "";
      }
      catch ( Exception erro )
      {
        MensagemErro = erro.Message;
        _sqlTran = null;
        _transacao = false;

      }
    }

    public void Rollback ( )
    {
      try
      {
        _sqlTran.Rollback ( );
        _sqlTran = null;
        MensagemErro = "";
        _transacao = false;
      }
      catch ( Exception erro )
      {
        MensagemErro = erro.Message;
        _sqlTran = null;
        _transacao = false;
      }
    }

    public Boolean ExecutaSql ( string sql, ref String mensagem )
    {
      Identity = 0;
      Boolean sucesso;
      _cmdSql = _connSql.CreateCommand ( );
      if ( _transacao )
      {
        _cmdSql.Transaction = _sqlTran;
      }
      _cmdSql.CommandText = sql;
      try
      {
        _cmdSql.ExecuteNonQuery ( );
        _cmdSql.CommandText = "SELECT @@Identity";
        try
        {
          Identity = Convert.ToInt32 ( _cmdSql.ExecuteScalar ( ) );
        }
        catch
        {
          Identity = 0;
        }
        _cmdSql.Dispose ( );
        MensagemErro = "";
        sucesso = true;
      }
      catch ( Exception erro )
      {
        MensagemErro = erro.Message;
        mensagem = erro.Message;
        sucesso = false;
      }
      return sucesso;
    }

    public Boolean ExecutaSql ( string pSql )
    {
      String mensagem = "";
      Boolean retorno = ExecutaSql(pSql, ref mensagem);
      return retorno;
    }

    public Boolean CriarSqlComand ( )
    {
      _cmdSql = _connSql.CreateCommand ( );
      return true;
    }

    public Boolean AdicionarParametro ( String param, String valor = null )
    {
      _cmdSql.Parameters.Add(valor == null
        ? new SqlParameter(param, DBNull.Value)
        : new SqlParameter(param, valor.Trim()));
      return true;
    }

    public int ExecutaProcedure ( string procedure )
    {
      int valorRetorno;
      if ( _transacao )
      {
        _cmdSql.Transaction = _sqlTran;
      }
      _cmdSql.CommandText = procedure;
      _cmdSql.CommandType = CommandType.StoredProcedure;
      SqlParameter parm = new SqlParameter ( "@return", SqlDbType.Int );
      parm.Direction = ParameterDirection.ReturnValue;
      _cmdSql.Parameters.Add ( parm );
      try
      {
        _cmdSql.ExecuteNonQuery ( );
        valorRetorno = ( int )( _cmdSql.Parameters [ "@return" ].Value );
        _cmdSql.Dispose ( );
        MensagemErro = "";
      }
      catch ( Exception erro )
      {
        MensagemErro = erro.Message;
        valorRetorno = 0;
      }
      return valorRetorno;
    }

    public DataSet DataSet ( String sql )
    {
      try
      {
        _cmdSql = _connSql.CreateCommand ( );
        if ( _transacao )
        {
          _cmdSql.Transaction = _sqlTran;
        }
        _cmdSql.CommandText = sql;
        SqlDataAdapter da = new SqlDataAdapter ( );
        da.SelectCommand = _cmdSql;
        DataSet dt = new DataSet ( );
        da.Fill ( dt );
        da.Dispose ( );
        return dt;
      }
      catch ( Exception erro )
      {
        MensagemErro = erro.Message;
        return null;
      }
    }

    public SqlDataReader DataReader ( string sql )
    {
      if ( _connSql != null && _connSql.State == ConnectionState.Closed )
      {
        Open ( );
      }
      if ( _connSql != null )
      {
        using (_cmdSql = _connSql.CreateCommand())
        {
          if (_transacao )
          {
            _cmdSql.Transaction = _sqlTran;
          }
          _cmdSql.CommandText = sql;
          try
          {
            MensagemErro = "";
            try
            {
              _connSql.Open();
            }
            catch
            {
              _conectado = false;
            }
            _cmdSql.CommandTimeout = 2;
            _dtrSql = _cmdSql.ExecuteReader();
          }
          catch (Exception erro)
          {
            MensagemErro = erro.Message;
          }
        }
      }
      return _dtrSql;
    }

    public void Close ( )
    {
      try
      {
        _connSql.Close ( );
        MensagemErro = "";
        _conectado = false;
      }
      catch ( Exception erro )
      {
        Android.Util.Log.Debug ( "mono", "Close - " + erro.Message );
        MensagemErro = erro.Message;
        _conectado = false;
      }
    }

    public void Dispose ( )
    {
      try
      {
        _connSql.Close ( );
        _connSql.Dispose ( );
        _conectado = false;
      }
      catch
      {
        _mensagemErro = @"Erro ao destruir a classe";
      }
    }

    public static string LerIniParam ( string iniFileName, string searchKey )
    {
      string keyValue = null;
      using ( StreamReader sr = new StreamReader ( iniFileName ) )
      {
        string inp;
        while ( ( inp = sr.ReadLine ( ) ) != null )
        {
          var resultado = "";
          string[] parts = inp.Split ( new[ ] { ',', '=' }, StringSplitOptions.RemoveEmptyEntries );
          if ( parts.Length == 2 )
          {
            resultado = parts [ 1 ];
          }
          else
          {
            try
            {
              for ( int i = 1; i < parts.Length; i++ )
              {
                if ( i != 1 )
                  resultado = resultado + "=";
                resultado = resultado + parts [ i ];
              }
            }
            catch ( Exception e )
            {
              Android.Util.Log.Debug ( "mono", "erro = " + e.Message );
            }
          }
          if ( ( parts.Length > 2 ) && ( parts [ 0 ] == searchKey ) )
          {
            keyValue = resultado;
          }
        }
      }
      return keyValue;
    }

  }
}
