using System;
using Android.App;
using Android.Views;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lorenzetti.DB;

namespace Lor0138.Classes.Filtro
{

  public class PopUp
  {

    private readonly Config    _bcoSql;
    private readonly Activity  _activityMestre;
    private readonly AcessoSql _acessoSql;
    private readonly String    _filtro;
    private Adapter            _popUpAdapter;
    private ListView           _listViewDetalhe;
    private AlertDialog        _alertDialog;
    private Boolean            _aberto;
    private ProgressDialog     _progress;
    private ProgressDialogTask _task;
    private Consultas.Item.Classe _item;

    public bool Aberto
    {
      get
      {
        return _aberto;
      }
    }

    public Consultas.Item.Classe Item
    {
      get
      {
        return _item;
      }
      set
      {
        _item = value;
      }
    }

    public PopUp ( Config bcoSql, AcessoSql acessoSql, Activity activityMestre, String filtro )
    {
      _bcoSql = bcoSql;
      _activityMestre = activityMestre;
      _acessoSql = acessoSql;
      _filtro = filtro;
    }

    public event EventHandler ObtemItemPopUp = new EventHandler ( ( e, a ) =>
    {
    } );

    public void Exibe ( EditText codigoItem  )
    {
      _aberto = true;
      var inflater = LayoutInflater.From ( _activityMestre );
      var vwPopUp = inflater.Inflate (  Resource.Layout.PopUp , null );
      _listViewDetalhe = vwPopUp.FindViewById<ListView> ( Resource.Id.lvwDetalhe );
      _listViewDetalhe.ItemClick += delegate ( object sender, AdapterView.ItemClickEventArgs e )
      {
        Detalhe popUpDetalhe = _popUpAdapter.GetItemAtPosition ( e.Position );
        codigoItem.Tag = popUpDetalhe.CodigoItem;
        codigoItem.Text = popUpDetalhe.CodigoItem;
        _aberto = false;
        _alertDialog.Dismiss ( );
        _item = new Consultas.Item.Classe(_bcoSql, _acessoSql, _activityMestre, popUpDetalhe.CodigoEmpresa, popUpDetalhe.CodigoItem);
        ObtemItemPopUp ( this, new EventArgs ( ) );
      };
      ThreadingProcessar ( );
      var builder = new AlertDialog.Builder ( _activityMestre );
      builder.SetTitle ( "Itens" );
      builder.SetView ( vwPopUp );
      builder.SetNegativeButton ( "Fechar", delegate
      {
        _aberto = false;
        _alertDialog.Dismiss ( );
      } );
      builder.SetCancelable ( false );
      _alertDialog = builder.Create ( );
    }

    private void ThreadingProcessar ( )
    {
      _progress = new ProgressDialog ( _activityMestre )
      {
        Indeterminate = false
      };
      _progress.SetCancelable ( false );
      _progress.SetMessage ( "Aguarde, carregando ..." );
      _progress.Show ( );
      _task = new ProgressDialogTask
      {
        RunInBackgroundMethod = Processar,
        OnPostExecuteMethod = TerminarProcesso
      };
      _task.Execute ( );
    }

    private Boolean Processar ( )
    {
      _popUpAdapter = new Adapter ( _activityMestre, _acessoSql, _filtro );
      return ( true );
    }

    private Boolean TerminarProcesso ( )
    {
      _listViewDetalhe.Adapter = _popUpAdapter;
      _progress.Dismiss ( );
      _alertDialog.Show ( );
      return ( true );
    }

  }
}