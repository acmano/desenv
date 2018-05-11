using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Lor0138.Classes.Comum
{
  public static class DbConvert
  {

    public static bool GetBoolean ( DataRow dataRow, String columnName )
    {
      return ( !dataRow.IsNull ( columnName ) && Convert.ToBoolean ( dataRow [ columnName ] ) );
    }

    public static bool GetBoolean ( SqlDataReader dataReader, String columnName )
    {
      return ( !dataReader.IsDBNull ( dataReader.GetOrdinal ( columnName ) ) && dataReader.GetBoolean ( dataReader.GetOrdinal ( columnName ) ) );
    }

    public static bool GetBoolean ( List<Coluna> colunas, String columnName )
    {
      return ( Convert.ToBoolean ( colunas.Find ( item => item.ColumnName == columnName ).Value ) );
    }

    public static Int32 GetInt32 ( DataRow dataRow, String columnName )
    {
      return ( dataRow.IsNull ( columnName ) ? 0 : Convert.ToInt32 ( dataRow [ columnName ] ) );
    }

    public static Int32 GetInt32 ( SqlDataReader dataReader, String columnName )
    {
      Int32 retorno = 0;
      if (dataReader != null)
      {
        if ( !String.IsNullOrEmpty ( columnName ) )
        {
          var indice = dataReader.GetOrdinal ( columnName );
          if ( !dataReader.IsDBNull ( indice ) )
          {
            retorno = Convert.ToInt32(dataReader [ columnName ].ToString ( ));
          }
        }
      }
      return ( retorno );
    }

    public static Int32 GetInt32 ( List<Coluna> colunas, String columnName )
    {
      return ( Convert.ToInt32 ( colunas.Find ( item => item.ColumnName == columnName ).Value ) );
    }

    public static Int64 GetInt64 ( DataRow dataRow, String columnName )
    {
      return ( dataRow.IsNull ( columnName ) ? 0L : Convert.ToInt64 ( dataRow [ columnName ] ) );
    }

    public static Int64 GetInt64 ( SqlDataReader dataReader, String columnName )
    {
      return ( dataReader.IsDBNull ( dataReader.GetOrdinal ( columnName ) ) ? 0L : dataReader.GetInt64 ( dataReader.GetOrdinal ( columnName ) ) );
    }

    public static Int64 GetInt64 ( List<Coluna> colunas, String columnName )
    {
      return ( Convert.ToInt64 ( colunas.Find ( item => item.ColumnName == columnName ).Value ) );
    }

    public static String GetString ( DataRow dataRow, String columnName )
    {
      return ( dataRow.IsNull ( columnName ) ? String.Empty : dataRow [ columnName ].ToString ( ).Trim ( ) );
    }

    public static String GetString ( SqlDataReader dataReader, String columnName )
    {
      String retorno = String.Empty;
      if ( dataReader != null )
      {
        if ( !String.IsNullOrEmpty ( columnName ) )
        {
          var indice = dataReader.GetOrdinal ( columnName );
          try
          {
            if ( dataReader [ columnName ] != null )
            {
              retorno = dataReader [ columnName ].ToString ( );
            }
          }
          catch (Exception e)
          {
            Console.WriteLine(e);
            throw;
          }

          //if ( !dataReader.IsDBNull ( indice ) )
          //{
          //  retorno = dataReader [ columnName ].ToString ( ) ;
          //}
        }
      }
      return ( retorno );
    }

    public static String GetString ( List<Coluna> colunas, String columnName )
    {
      return ( colunas.Find ( item => item.ColumnName == columnName ).Value.ToString ( ).Trim ( ) );
    }

    public static DateTime GetDateTime ( DataRow dataRow, String columnName )
    {
      return ( dataRow.IsNull ( columnName ) ? DateTime.MinValue : Convert.ToDateTime ( dataRow [ columnName ] ) );
    }

    public static DateTime GetDateTime ( SqlDataReader dataReader, String columnName )
    {
      DateTime retorno = DateTime.MinValue;
      if ( dataReader != null )
      {
        if ( !String.IsNullOrEmpty ( columnName ) )
        {
          var indice = dataReader.GetOrdinal ( columnName );
          if ( !dataReader.IsDBNull ( indice ) )
          {
            String x = dataReader[columnName].ToString();
            retorno = Convert.ToDateTime ( x );
          }
        }
      }
      return ( retorno );
    }

    public static DateTime GetDateTime ( List<Coluna> colunas, String columnName )
    {
      return ( Convert.ToDateTime ( colunas.Find ( item => item.ColumnName == columnName ).Value ) );
    }

    public static Double GetDouble ( DataRow dataRow, String columnName )
    {
      return ( dataRow.IsNull ( columnName ) ? 0 : Convert.ToDouble( dataRow [ columnName ] ) );
    }

    public static Double GetDouble ( SqlDataReader dataReader, String columnName )
    {
      Double retorno = 0.0;
      if ( dataReader != null )
      {
        if ( !String.IsNullOrEmpty ( columnName ) )
        {
          var indice = dataReader.GetOrdinal ( columnName );
          if ( !dataReader.IsDBNull ( indice ) )
          {
            retorno = Convert.ToDouble(dataReader[columnName].ToString());
          }
        }
      }
      return ( retorno );
    }

    public static Double GetDouble ( List<Coluna> colunas, String columnName )
    {
      return ( Convert.ToDouble ( colunas.Find ( item => item.ColumnName == columnName ).Value ) );
    }
    
    public static void SetColumnValue ( List<Coluna> colunas, String columnName, Object value )
    {
      colunas.Find ( item => item.ColumnName == columnName ).Value = value;
    }

  }
}
