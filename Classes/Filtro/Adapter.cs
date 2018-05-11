using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Android.App;
using Android.Views;
using Android.Widget;
using Lor0138.Classes.Comum;

namespace Lor0138.Classes.Filtro
{
  public class Detalhe
  {
    public String CodigoEmpresa
    {
      get;
      set;
    }
    public String CodigoItem
    {
      get;
      set;
    }
    public String DescricaoItem
    {
      get;
      set;
    }
  }

  public class Adapter : BaseAdapter
  {
    private readonly Activity _activityMestre;
    private readonly List<Detalhe> _detalhes;

    public Adapter ( Activity activityMestre, AcessoSql acessoSql, String filtro )
    {
      _activityMestre = activityMestre;
      var query = new StringBuilder ( );
      query.AppendFormat ( Sql.QueryItem, acessoSql.OpenQuery, filtro );
      var banco = new Msde ( acessoSql );
      banco.Open ( );
      SqlDataReader reader = banco.DataReader ( query.ToString ( ) );
      _detalhes = new List<Detalhe> ( );
      while ( reader.Read ( ) )
      {
        Detalhe detalhe = new Detalhe
        {
          CodigoEmpresa = String.Empty
        , CodigoItem = String.Empty
        , DescricaoItem = String.Empty
        };
        try
        {
          detalhe.CodigoEmpresa = reader["CodigoEmpresa"].ToString();
          detalhe.CodigoItem = reader [ "Codigoitem" ].ToString ( );
          detalhe.DescricaoItem = reader [ "DescricaoItem" ].ToString ( );
        }
        catch
        {
          detalhe.CodigoEmpresa = String.Empty;
          detalhe.CodigoItem = String.Empty;
          detalhe.DescricaoItem = String.Empty;
        }
        _detalhes.Add ( detalhe );
      }
      if ( _detalhes.Count <= 0 )
      {
        Detalhe detalhe = new Detalhe
        {
          CodigoEmpresa = String.Empty
        , CodigoItem = String.Empty
        , DescricaoItem = @"* Nenhum registro encontrado..."
        };
        _detalhes.Add ( detalhe );
      }
      reader.Close ( );
      reader.Dispose ( );
      banco.Close ( );
    }

    public override int Count
    {
      get
      {
        return _detalhes.Count;
      }
    }

    public override Java.Lang.Object GetItem ( int position )
    {
      return position;
    }

    public override long GetItemId ( int position )
    {
      return position;
    }

    public override View GetView ( int position, View convertView, ViewGroup parent )
    {
      var item = _detalhes [ position ];
      var view = convertView;
      if ( convertView == null )
      {
        view = ( _activityMestre.LayoutInflater.Inflate ( Resource.Layout.PopUpDetalhe, parent, false ) ) as LinearLayout;
      }
      if ( view != null )
      {
        TextView codigo = view.FindViewById ( Resource.Id.txtCodigoItem ) as TextView;
        TextView descricao = view.FindViewById ( Resource.Id.txtDescricaoItem ) as TextView;
        if ( codigo != null )
        {
          codigo.SetText ( item.CodigoItem.Trim ( ), TextView.BufferType.Normal );
        }
        if ( descricao != null )
        {
          descricao.SetText ( item.DescricaoItem.Trim ( ), TextView.BufferType.Normal );
        }
      }
      return view;
    }

    public Detalhe GetItemAtPosition ( int position )
    {
      return _detalhes [ position ];
    }
  }

}