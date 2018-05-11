using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Android.App;
using Android.Views;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lorenzetti.DB;

namespace Lor0138.Classes.Consultas.Item
{
  public class Classe
  {

    public class VariaveisClasse
    {
      #region Privadas
      private Boolean      _ok;
      private Config       _bcoSql;
      private AcessoSql    _acessoSql;
      private List<Coluna> _colunas;
      private String       _codigoEmpresa;
      private String       _codigoItem;
      private String       _descricaoItem;
      private String       _codigoUnidadeMedida;
      #endregion

      #region Públicas
      public string CodigoEmpresa
      {
        get { return _codigoEmpresa; }
        set { _codigoEmpresa = value; }
      }

      public string CodigoItem
      {
        get { return _codigoItem; }
        set { _codigoItem = value; }
      }

      public string DescricaoItem
      {
        get { return _descricaoItem; }
        set { _descricaoItem = value; }
      }

      public string CodigoUnidadeMedida
      {
        get { return _codigoUnidadeMedida; }
        private set { _codigoUnidadeMedida = value; }
      }

      public bool Ok
      {
        get
        {
          return _ok;
        }
        set
        {
          _ok = value;
        }
      }

      public Config BcoSql
      {
        get
        {
          return _bcoSql;
        }
        set
        {
          _bcoSql = value;
        }
      }

      public AcessoSql Sql
      {
        get
        {
          return _acessoSql;
        }
        set
        {
          _acessoSql = value;
        }
      }

      public List<Coluna> Colunas
      {
        get
        {
          return _colunas;
        }
        set
        {
          _colunas = value;
        }
      }

      #endregion

      public void Clear()
      {
        CodigoEmpresa = String.Empty;
        CodigoItem = String.Empty;
        DescricaoItem = String.Empty;
        CodigoUnidadeMedida = String.Empty;
      }

      public VariaveisClasse()
      {
        Clear();
        CriaColunas();
      }

      public VariaveisClasse(DataRow dataRow)
      {
        Clear();
        CriaColunas();
        Popula(dataRow);
      }

      public VariaveisClasse(SqlDataReader dataReader = null)
      {
        Clear();
        CriaColunas();
        Popula(dataReader);
      }

      public VariaveisClasse(Config bcoSql, AcessoSql sql, String codigoEmpresa, String codigoItem)
      {
        Clear();
        CriaColunas();
        BcoSql = bcoSql;
        Sql = sql;
        Popula( codigoEmpresa, codigoItem);
      }

      private void CriaColunas()
      {
        _colunas = new List<Coluna>
        {
          new Coluna(0, "CodigoEmpresa", "", typeof(String), true, false, false),
          new Coluna(1, "CodigoItem", "", typeof(String), true, false, false),
          new Coluna(2, "CodigoUnidadeMedida", "", typeof(String), false, false, false),
          new Coluna(3, "DescricaoItem", "", typeof(String), false, false, false)
        };
      }

      private void Popula(DataRow dataRow)
      {
        CodigoEmpresa = DbConvert.GetString ( dataRow, "CodigoEmpresa" );
        CodigoItem = DbConvert.GetString ( dataRow, "CodigoItem" );
        DescricaoItem = DbConvert.GetString(dataRow, "DescricaoItem");
        CodigoUnidadeMedida = DbConvert.GetString(dataRow, "CodigoUnidadeMedida");
        Ok = true;
      }

      private void Popula(SqlDataReader dataReader = null)
      {
        if (dataReader != null)
        {
          CodigoEmpresa = DbConvert.GetString ( dataReader, "CodigoEmpresa" );
          CodigoItem = DbConvert.GetString ( dataReader, "CodigoItem" );
          DescricaoItem = DbConvert.GetString(dataReader, "DescricaoItem");
          CodigoUnidadeMedida = DbConvert.GetString(dataReader, "CodigoUnidadeMedida");
          Ok = true;
        }
      }

      private void Popula( String codigoEmpresa, String codigoItem )
      {
        var query = new StringBuilder ( );
        query.AppendFormat ( Item.Sql.Query, Sql.OpenQuery, codigoEmpresa, codigoItem );
        var banco = new Msde ( _acessoSql );
        banco.Open ( );
        SqlDataReader reader = banco.DataReader ( query.ToString ( ) );
        while ( reader.Read ( ) )
        {
          Popula(reader);
          break;
        }
        reader.Close ( );
        reader.Dispose ( );
        banco.Close ( );
      }


    }

    public class CamposXml
    {

      #region Privadas

      #region Estrutura
      private RelativeLayout _rloItem;
      #endregion

      #region Item
      private TextView _txtItemCodigoItem;
      private TextView _txtItemDescricaoItem;
      private TextView _txtItemCodigoUnidadeMedida;
      #endregion

      #endregion
      
      #region Publicas

      #region Estrutura
      public RelativeLayout RloItem
      {
        get { return _rloItem; }
        set { _rloItem = value; }
      }
      #endregion

      #region Item
      public TextView TxtItemCodigoItem
      {
        get { return _txtItemCodigoItem; }
        private set { _txtItemCodigoItem = value; }
      }

      public TextView TxtItemDescricaoItem
      {
        get { return _txtItemDescricaoItem; }
        private set { _txtItemDescricaoItem = value; }
      }

      public TextView TxtItemCodigoUnidadeMedida
      {
        get { return _txtItemCodigoUnidadeMedida; }
        private set { _txtItemCodigoUnidadeMedida = value; }
      }
      #endregion

      #endregion

      public CamposXml ( Activity activity )
      {
        Bind ( activity );
      }

      private void Bind(Activity activity)
      {
        #region Estrutura
        BindEstrutura(activity);
        #endregion

        #region Item
        BindCodigoItem(activity);
        BindDescricaoItem(activity);
        BindCodigoUnidadeMedida(activity);
        #endregion
      }

      #region Estrutura - Bind
      private void BindEstrutura ( Activity activity )
      {
        RloItem = activity.FindViewById<RelativeLayout> ( Resource.Id.item );
      }
      #endregion

      #region Item - Bind
      private void BindCodigoItem ( Activity activity )
      {
        TxtItemCodigoItem = activity.FindViewById<TextView> ( Resource.Id.txtItemCodigoItem );
      }

      private void BindDescricaoItem ( Activity activity )
      {
        TxtItemDescricaoItem = activity.FindViewById<TextView> ( Resource.Id.txtItemDescricaoItem );
      }

      private void BindCodigoUnidadeMedida ( Activity activity )
      {
        TxtItemCodigoUnidadeMedida = activity.FindViewById<TextView> ( Resource.Id.txtItemCodigoUnidadeMedida );
      }
      #endregion

      public void Clear()
      {
        #region Item
        TxtItemCodigoItem.Text = String.Empty;
        TxtItemDescricaoItem.Text = String.Empty;
        TxtItemCodigoUnidadeMedida.Text = String.Empty;
        #endregion
      }

      public void AtualizaCampos(VariaveisClasse valor)
      {
        #region Item
        TxtItemCodigoItem.Text = valor.CodigoItem.Trim();
        TxtItemDescricaoItem.Text = valor.DescricaoItem.Trim();
        TxtItemCodigoUnidadeMedida.Text = valor.CodigoUnidadeMedida.Trim();
        #endregion
      }

    }

    #region Privadas
    private Boolean            _ok;
    private Config             _bcoSql;
    private AcessoSql          _acessoSql;
    private List<Coluna>       _colunas;
    private VariaveisClasse    _variaveis;
    private CamposXml          _campos;
    #endregion

    #region Públicas
    public bool Ok
    {
      get { return _ok; }
      set { _ok = value; }
    }

    public Config BcoSql
    {
      get { return _bcoSql; }
      set { _bcoSql = value; }
    }

    public AcessoSql Sql
    {
      get { return _acessoSql; }
      set { _acessoSql = value; }
    }

    public List<Coluna> Colunas
    {
      get { return _colunas; }
      set { _colunas = value; }
    }

    public CamposXml Campos
    {
      get { return _campos; }
      set { _campos = value; }
    }

    public VariaveisClasse Variaveis
    {
      get
      {
        return _variaveis;
      }
      set
      {
        _variaveis = value;
      }
    }
    #endregion

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity )
    {
      BcoSql = bcoSql;
      Sql = acessoSql;
      _variaveis = new VariaveisClasse();
      _campos = new CamposXml(activity);
      Clear ( );
    }

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity, DataRow dataRow )
    {
      BcoSql = bcoSql;
      Sql = acessoSql;
      Popula ( dataRow );
      Ok = _variaveis.Ok;
      _campos = new CamposXml(activity);
    }

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity, SqlDataReader dataReader )
    {
      BcoSql = bcoSql;
      Sql = acessoSql;
      Popula ( dataReader );
      Ok = _variaveis.Ok;
      _campos = new CamposXml ( activity );
    }

    public Classe ( Config bcoSql, AcessoSql acessoSql, Activity activity, String codigoEmpresa, String codigoItem )
    {
      BcoSql = bcoSql;
      Sql = acessoSql;
      Popula( codigoEmpresa, codigoItem );
      Ok = _variaveis.Ok;
      _campos = new CamposXml ( activity );
    }

    public void Clear()
    {
      Ok = false;
      _variaveis.Clear();
      _campos.Clear();
    }

    private void Popula(String codigoEmpresa, String codigoItem)
    {
      try
      {
        _variaveis = new VariaveisClasse( BcoSql, Sql, codigoEmpresa, codigoItem);
        Ok = true;
      }
      catch (Exception)
      {
        Clear();
      }
    }

    private void Popula(DataRow dataRow)
    {
      try
      {
        _variaveis = new VariaveisClasse(dataRow);
        Ok = true;
      }
      catch (Exception)
      {
        Clear();
      }
    }

    private void Popula(SqlDataReader dataReader)
    {
      try
      {
        _variaveis = new VariaveisClasse(dataReader);
        Ok = true;
      }
      catch (Exception)
      {
        Clear();
      }
    }

  }
}