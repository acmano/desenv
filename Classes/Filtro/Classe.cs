using System;
using System.Data;
using Android.App;
using Android.Views;
using Android.OS;
using System.Data.SqlClient;
using System.Text;
using Android.Text;
using Android.Views.InputMethods;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lor0138.Classes.Consultas.Item;
using Lorenzetti.DB;

namespace Lor0138.Classes.Filtro
{
  public class Classe : Activity
  {

    private readonly Activity _activity;
    private ProgressDialog _progress;
    private String _codigoItem;
    private String _descricaoItem;
    private String _codigoTipoItem;
    private String _codigoFamilia;
    private String _codigoGrupoControleEstoque;
    private String _codigoLinhaProduto;
    private String _codigoLinhaReceita;
    private String _codigoSegmentoMercado;
    private String _codigoClasseUso;
    private String _codigoEmpresa;
    private static Consultas.Item.Classe _item;

    private EditText _txtFiltroCodigoItem;
    private EditText _txtFiltroDescricaoItem;
    private EditText _txtFiltroCodigoTipoItem;
    private EditText _txtFiltroCodigoFamilia;
    private EditText _txtFiltroCodigoGrupoControleEstoque;
    private EditText _txtFiltroCodigoLinhaProduto;
    private EditText _txtFiltroCodigoLinhaReceita;
    private EditText _txtFiltroCodigoSegmentoMercado;
    private EditText _txtFiltroCodigoClasseUso;
    private Button   _btnPesquisar;
    private Button   _btnLimpar;
    private Config   _bcoSql;
    private readonly AcessoSql _acessoSql;
    private static PopUp    _popUp;
    private ProgressDialogTask _task;
    private Msde _banco;
    //private DataTable _dataTable;
    private SqlDataReader _reader;
    private Int32 _dataReaderRowsCount;


    public event EventHandler ObtemItem = new EventHandler ( ( e, a ) =>
    {
    } );

    public string CodigoItem
    {
      get
      {
        return _codigoItem;
      }
      set
      {
        _codigoItem = value;
      }
    }

    public string DescricaoItem
    {
      get
      {
        return _descricaoItem;
      }
      set
      {
        _descricaoItem = value;
      }
    }

    public string CodigoTipoItem
    {
      get
      {
        return _codigoTipoItem;
      }
      set
      {
        _codigoTipoItem = value;
      }
    }

    public string CodigoFamilia
    {
      get
      {
        return _codigoFamilia;
      }
      set
      {
        _codigoFamilia = value;
      }
    }

    public string CodigoGrupoControleEstoque
    {
      get
      {
        return _codigoGrupoControleEstoque;
      }
      set
      {
        _codigoGrupoControleEstoque = value;
      }
    }

    public string CodigoLinhaProduto
    {
      get
      {
        return _codigoLinhaProduto;
      }
      set
      {
        _codigoLinhaProduto = value;
      }
    }

    public string CodigoLinhaReceita
    {
      get
      {
        return _codigoLinhaReceita;
      }
      set
      {
        _codigoLinhaReceita = value;
      }
    }

    public string CodigoSegmentoMercado
    {
      get
      {
        return _codigoSegmentoMercado;
      }
      set
      {
        _codigoSegmentoMercado = value;
      }
    }

    public string CodigoClasseUso
    {
      get
      {
        return _codigoClasseUso;
      }
      set
      {
        _codigoClasseUso = value;
      }
    }

    public string FiltroQuery
    {
      get
      {
        return FiltroQueryString ( );
      }
    }

    private String FiltroMonta ( String mascara, String valor )
    {
      var filtroParcial = new StringBuilder ( );
      filtroParcial.Clear ( );
      if ( !String.IsNullOrEmpty ( valor ) )
      {
        filtroParcial.AppendFormat ( mascara, valor.Trim ( ).ToUpper ( ) );
      }
      return ( filtroParcial.ToString ( ) );
    }

    private String FiltroQueryString ( )
    {
      var filtro = new StringBuilder ( );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoEmpresa, _codigoEmpresa ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoItem, CodigoItem ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroDescricaoItem, DescricaoItem ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoTipoItem, CodigoTipoItem ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoFamilia, CodigoFamilia ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroGrupoControleEstoque, CodigoGrupoControleEstoque ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoLinhaProduto, CodigoLinhaProduto ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoLinhaReceita, CodigoLinhaReceita ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoSegmentoMercado, CodigoSegmentoMercado ) );
      filtro.Append ( FiltroMonta ( Sql.FiltroCodigoClasseUso, CodigoClasseUso ) );
      return filtro.ToString ( );
    }

    public EditText TxtFiltroCodigoItem
    {
      get
      {
        return _txtFiltroCodigoItem;
      }
      set
      {
        _txtFiltroCodigoItem = value;
      }
    }

    public EditText TxtFiltroDescricaoItem
    {
      get
      {
        return _txtFiltroDescricaoItem;
      }
      set
      {
        _txtFiltroDescricaoItem = value;
      }
    }

    public EditText TxtFiltroCodigoTipoItem
    {
      get
      {
        return _txtFiltroCodigoTipoItem;
      }
      set
      {
        _txtFiltroCodigoTipoItem = value;
      }
    }

    public EditText TxtFiltroCodigoFamilia
    {
      get
      {
        return _txtFiltroCodigoFamilia;
      }
      set
      {
        _txtFiltroCodigoFamilia = value;
      }
    }

    public EditText TxtFiltroCodigoGrupoControleEstoque
    {
      get
      {
        return _txtFiltroCodigoGrupoControleEstoque;
      }
      set
      {
        _txtFiltroCodigoGrupoControleEstoque = value;
      }
    }

    public EditText TxtFiltroCodigoLinhaProduto
    {
      get
      {
        return _txtFiltroCodigoLinhaProduto;
      }
      set
      {
        _txtFiltroCodigoLinhaProduto = value;
      }
    }

    public EditText TxtFiltroCodigoLinhaReceita
    {
      get
      {
        return _txtFiltroCodigoLinhaReceita;
      }
      set
      {
        _txtFiltroCodigoLinhaReceita = value;
      }
    }

    public EditText TxtFiltroCodigoSegmentoMercado
    {
      get
      {
        return _txtFiltroCodigoSegmentoMercado;
      }
      set
      {
        _txtFiltroCodigoSegmentoMercado = value;
      }
    }

    public EditText TxtFiltroCodigoClasseUso
    {
      get
      {
        return _txtFiltroCodigoClasseUso;
      }
      set
      {
        _txtFiltroCodigoClasseUso = value;
      }
    }

    public Button BtnPesquisar
    {
      get
      {
        return _btnPesquisar;
      }
      set
      {
        _btnPesquisar = value;
      }
    }

    public Button BtnLimpar
    {
      get
      {
        return _btnLimpar;
      }
      set
      {
        _btnLimpar = value;
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

    private void TxtFiltroCodigoItemLostFocus ( )
    {
      CodigoItem = TxtFiltroCodigoItem.Text;
    }

    private void BindCodigoItem ( )
    {
      TxtFiltroCodigoItem = _activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoItem );
      TxtFiltroCodigoItem.InputType = InputTypes.ClassPhone;
      TxtFiltroCodigoItem.FocusChange += delegate
      {
        TxtFiltroCodigoItemLostFocus ( );
      };
      TxtFiltroCodigoItem.KeyPress += ( object sender, View.KeyEventArgs e ) =>
      {
        e.Handled = false;
        if ( e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter )
        {
          CodigoItem = TxtFiltroCodigoItem.Text;
          e.Handled = true;
        }
      };
    }

    private void BindDescricaoItem ( )
    {
      TxtFiltroDescricaoItem = _activity.FindViewById<EditText> ( Resource.Id.txtFiltroDescricaoItem );
      TxtFiltroDescricaoItem.InputType = InputTypes.ClassText;
    }

    private void BindCodigoTipoItem ( )
    {
      TxtFiltroCodigoTipoItem = _activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoTipoItem );
      TxtFiltroCodigoTipoItem.InputType = InputTypes.ClassText;
    }

    private void BindCodigoFamilia ( )
    {
      TxtFiltroCodigoFamilia = _activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoFamilia );
      TxtFiltroCodigoFamilia.InputType = InputTypes.ClassText;
    }

    private void BindCodigoGrupoControleEstoque ( )
    {
      TxtFiltroCodigoGrupoControleEstoque = _activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoGrupoControleEstoque );
      TxtFiltroCodigoGrupoControleEstoque.InputType = InputTypes.ClassPhone;
    }

    private void BindCodigoLinhaProduto ( )
    {
      TxtFiltroCodigoLinhaProduto = _activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoLinhaProduto );
      TxtFiltroCodigoLinhaProduto.InputType = InputTypes.ClassPhone;
    }

    private void BindCodigoLinhaReceita ( )
    {
      TxtFiltroCodigoLinhaReceita = _activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoLinhaReceita );
      TxtFiltroCodigoLinhaReceita.InputType = InputTypes.ClassPhone;
    }

    private void BindCodigoSegmentoMercado ( )
    {
      TxtFiltroCodigoSegmentoMercado = _activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoSegmentoMercado );
      TxtFiltroCodigoSegmentoMercado.InputType = InputTypes.ClassPhone;
    }

    private void BindCodigoClasseUso ( )
    {
      TxtFiltroCodigoClasseUso = _activity.FindViewById<EditText> ( Resource.Id.txtFiltroCodigoClasseUso );
      TxtFiltroCodigoClasseUso.InputType = InputTypes.ClassPhone;
    }

    private void BindPesquisar ( )
    {
      BtnPesquisar = _activity.FindViewById<Button> ( Resource.Id.btnPesquisar );
      BtnPesquisar.Click += delegate
      {
        Pesquisar ( );
      };
    }

    private void BindLimpar ( )
    {
      BtnLimpar = _activity.FindViewById<Button> ( Resource.Id.btnLimpar );
      BtnLimpar.Click += delegate
      {
        Limpar ( );
      };
    }

    private void Clear ( )
    {
      try
      {
        TxtFiltroCodigoItem.Text = String.Empty;
        TxtFiltroDescricaoItem.Text = String.Empty;
        TxtFiltroCodigoTipoItem.Text = String.Empty;
        TxtFiltroCodigoFamilia.Text = String.Empty;
        TxtFiltroCodigoGrupoControleEstoque.Text = String.Empty;
        TxtFiltroCodigoLinhaProduto.Text = String.Empty;
        TxtFiltroCodigoLinhaReceita.Text = String.Empty;
        TxtFiltroCodigoSegmentoMercado.Text = String.Empty;
        TxtFiltroCodigoClasseUso.Text = String.Empty;
      }
      catch ( Exception e )
      {
        String erro = e.Message;
      }
    }

    public void Atualiza ( )
    {
      TxtFiltroCodigoItem.Text = CodigoItem;
      TxtFiltroDescricaoItem.Text = DescricaoItem;
      TxtFiltroCodigoTipoItem.Text = CodigoTipoItem;
      TxtFiltroCodigoFamilia.Text = CodigoFamilia;
      TxtFiltroCodigoGrupoControleEstoque.Text = CodigoGrupoControleEstoque;
      TxtFiltroCodigoLinhaProduto.Text = CodigoLinhaProduto;
      TxtFiltroCodigoLinhaReceita.Text = CodigoLinhaReceita;
      TxtFiltroCodigoSegmentoMercado.Text = CodigoSegmentoMercado;
      TxtFiltroCodigoClasseUso.Text = CodigoClasseUso;
    }

    public Boolean Vazio()
    {
      return
      (
        String.IsNullOrEmpty(_codigoItem)
        && String.IsNullOrEmpty ( _descricaoItem )
        && String.IsNullOrEmpty ( _codigoTipoItem )
        && String.IsNullOrEmpty ( _codigoFamilia )
        && String.IsNullOrEmpty(_codigoGrupoControleEstoque)
        && String.IsNullOrEmpty ( _codigoLinhaProduto)
        && String.IsNullOrEmpty( _codigoLinhaReceita)
        && String.IsNullOrEmpty(_codigoSegmentoMercado)
        && String.IsNullOrEmpty ( _codigoClasseUso)

      );
    }

    private void Bind ( )
    {
      BindCodigoItem ( );
      BindDescricaoItem ( );
      BindCodigoTipoItem ( );
      BindCodigoFamilia ( );
      BindCodigoGrupoControleEstoque ( );
      BindCodigoLinhaProduto ( );
      BindCodigoLinhaReceita ( );
      BindCodigoSegmentoMercado ( );
      BindCodigoClasseUso ( );
      BindPesquisar ( );
      BindLimpar ( );
      Clear ( );
    }

    private void SetVariaveis ( )
    {
      CodigoItem = TxtFiltroCodigoItem.Text;
      CodigoTipoItem = TxtFiltroCodigoTipoItem.Text;
      CodigoFamilia = TxtFiltroCodigoFamilia.Text;
      CodigoGrupoControleEstoque = TxtFiltroCodigoGrupoControleEstoque.Text;
      CodigoLinhaProduto = TxtFiltroCodigoLinhaProduto.Text;
      CodigoLinhaReceita = TxtFiltroCodigoLinhaReceita.Text;
      CodigoSegmentoMercado = TxtFiltroCodigoSegmentoMercado.Text;
      CodigoClasseUso = TxtFiltroCodigoClasseUso.Text;
    }

    private void Pesquisar ( )
    {
      if ( _activity.CurrentFocus != null )
      {
        HideSoftKeyboard ( _activity, _activity.CurrentFocus.WindowToken );
      }
      SetVariaveis ( );
      if (Vazio())
      {
        Tools tools = new Tools();
        tools.QuestionMessageBox(_activity, ThreadingPesquisar, "Excesso de resultados",
          "Não foi informado nenhum critério de pesquisa. Serão exibidos muitos itens. Confirma a pesquisa?");
      }
      else
      {
        ThreadingPesquisar ( );
      }
    }

    private bool ThreadingPesquisar ( )
    {
      _progress = new ProgressDialog ( _activity )
      {
        Indeterminate = false
      };
      _progress.SetCancelable ( false );
      _progress.SetMessage ( "Aguarde, pesquisando itens ..." );
      _progress.Show ( );
      _task = new ProgressDialogTask
      {
        RunInBackgroundMethod = PesquisaExecuta
      , OnPostExecuteMethod = PesquisaFinaliza
      };
      _task.Execute ( );
      return (true);
    }

    private Boolean PesquisaExecuta ( )
    {
      var query = new StringBuilder ( );
      query.AppendFormat ( Sql.QueryItem, _acessoSql.OpenQuery, FiltroQuery );
      _banco = new Msde ( _acessoSql );
      _banco.Open ( );
      _reader = _banco.DataReader ( query.ToString ( ) );
      _dataReaderRowsCount = 0;
      while (_reader.Read())
      {
        _dataReaderRowsCount++;
      }
      _reader.Close();
      _reader = _banco.DataReader ( query.ToString ( ) );
      Item.Clear ( );
      return ( true );
    }

    private Boolean PesquisaFinaliza ( )
    {
      _progress.Dismiss ( );
      if ( _dataReaderRowsCount > 1 )
      {
        _popUp = new PopUp ( _bcoSql, _acessoSql, _activity, FiltroQuery );
        _popUp.ObtemItemPopUp += delegate
        {
          ObtemItemPopUp ( );
        };
        _popUp.Exibe ( TxtFiltroCodigoItem );
      }
      else
      {
        if (_reader.Read())
        {
          _task = null;
          ThreadingExibir ( );
        }
      }
      return ( true );
    }

    private void ObtemItemPopUp()
    {
      _item = _popUp.Item;
      ObtemItem(this, EventArgs.Empty);
    }

    private void ThreadingExibir ( )
    {
      _progress = new ProgressDialog ( _activity )
      {
        Indeterminate = false
      };
      _progress.SetCancelable ( false );
      _progress.SetMessage ( "Aguarde, exibindo item ..." );
      _progress.Show ( );
      _task = new ProgressDialogTask
      {
        RunInBackgroundMethod = ExibeExecuta
      , OnPostExecuteMethod = ExibeFinaliza
      };
      _task.Execute ( );
    }

    private Boolean ExibeExecuta ( )
    {
      _item = new Consultas.Item.Classe(_bcoSql, _acessoSql, _activity, _reader);
      return ( true );
    }

    private Boolean ExibeFinaliza ( )
    {
      _progress.Dismiss ( );
      _reader.Close ( );
      _reader.Dispose ( );
      _banco.Close ( );
      ObtemItem ( this, EventArgs.Empty );
      return ( true );
    }

    public void Limpar ( )
    {
      if ( _activity.CurrentFocus != null )
      {
        HideSoftKeyboard ( _activity, _activity.CurrentFocus.WindowToken );
      }
      Clear ( );
      SetVariaveis ( );
    }

    private void HideSoftKeyboard ( Activity activity, IBinder windowToken )
    {
      InputMethodManager inputMethodManager = ( InputMethodManager )activity.GetSystemService ( InputMethodService );
      inputMethodManager.HideSoftInputFromWindow ( windowToken, 0 );
    }

    public Classe ( Activity activity, Config bcoSql, AcessoSql acessoSql, String codigoEmpresa )
    {
      _activity = activity;
      _bcoSql = bcoSql;
      _acessoSql = acessoSql;
      _codigoEmpresa = codigoEmpresa;
      _item = new Consultas.Item.Classe ( _bcoSql, _acessoSql, _activity );
      Bind ( );
      Clear ( );
    }

  }
}