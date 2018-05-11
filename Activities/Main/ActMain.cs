using System;
using System.Collections.Generic;
using Android.App;
using Android.Content.PM;
using Android.Graphics;
using Android.Views;
using Android.Views.Animations;
using Android.OS;
using Android.Widget;
using Lor0138.Classes.Comum;
using Lorenzetti;
using Lorenzetti.DB;

namespace Lor0138.Activities.Main
{
  [
    Activity
    (
      Label = "Lor0138"
      , MainLauncher = true
      , Icon = "@drawable/icon"
      , Theme = "@style/LorenTheme"
      , ScreenOrientation = ScreenOrientation.Landscape
    )
  ]

  public class ActMain : Activity
  {

    private enum Consultas
    {
      Consulta00,
      ConsultaDimensional
    };

    //private Stack<Consultas>                              _consultaStack;
    private GestureDetector                               _gestureDetector;
    private GestureListener                               _gestureListener;
    private ListView                                      _menuListView;
    private MenuListAdapterClass                          _objAdapterMenu;
    private ImageView                                     _menuIconImageView;
    private Int32                                         _intDisplayWidth;
    private Boolean                                       _isSingleTapFired;
    private TextView                                      _txtActionBarText;
    private ImageView                                     _btnDescExpander;

    private String                                        _codEmpresa;
    private LinearLayout                                  _filtro;
    private Classes.Filtro.Classe                         _filtroItem;
    private AcessoSql                                     _acessoSql;
    private AcessoSql.AcessoTipo                          _acessoTipo;
    private eAmbiente                                     _ambiente;
    private Classes.Consultas.Item.Classe                 _itemAtual;
    private Config                                        _bcoSql;
    private Classes.Consultas.Consulta00.Classe           _consulta00;
    private Classes.Consultas.ConsultaDimensionais.Classe _consultaDimensionais;

    public Classes.Consultas.Consulta00.Classe Consulta00
    {
      set { _consulta00 = value; }
      get { return _consulta00; }
    }

    public Classes.Consultas.ConsultaDimensionais.Classe ConsultaDimensionais
    {
      get { return _consultaDimensionais; }
      set { _consultaDimensionais = value; }
    }

    public Classes.Filtro.Classe FiltroItem
    {
      get { return _filtroItem; }
      set { _filtroItem = value; }
    }

    protected override void OnCreate ( Bundle bundle )
    {
      base.OnCreate ( bundle );
      Window.RequestFeature ( WindowFeatures.NoTitle );
      SetContentView ( Resource.Layout.Main );
      _codEmpresa = "10";
      AtualizaVersao ( );
      InitBanco ( );
      InitTela ( );
      InitMenu ( );
      InitClasses();
    }

    private void InitBanco()
    {
      _ambiente = eAmbiente.Desenvolvimento;
      _acessoTipo = AcessoSql.AcessoTipo.Desenvolvimento;
      _acessoSql = new AcessoSql ( _acessoTipo );
      _bcoSql = new Config ( _ambiente, eClientBanco.SQLServer, eBanco.sqlloren );
    }

    private void InitItemAtual()
    {
      _itemAtual = new Classes.Consultas.Item.Classe(_bcoSql, _acessoSql, this);
    }

    private void InitFiltroItem()
    {
      FiltroItem = new Classes.Filtro.Classe ( this, _bcoSql, _acessoSql, _codEmpresa );
      FiltroItem.BtnPesquisar.Click += delegate
      {
        FiltroMostraEsconde ( );
      };
      FiltroItem.ObtemItem += delegate
      {
        ObtemItem ( );
      };
    }
    
    private void InitConsulta00()
    {
      Consulta00 = new Classes.Consultas.Consulta00.Classe ( _bcoSql, _acessoSql, this, _itemAtual );
    }

    private void InitClasses()
    {
      InitItemAtual ( );
      InitFiltroItem();
      InitConsulta00();
    }

    private void AtualizaVersao ( )
    {
      var novaVersao = new AlteraVersao ( );
      Boolean lAtualizaVersao = false;
      novaVersao.TrocaVersao ( this, "", ref lAtualizaVersao );
    }

    private void ObtemItem()
    {
      _itemAtual = FiltroItem.Item;
      if ( _itemAtual.Ok )
      {
        Consulta00.CamposTela.Clear ( );
        InitConsulta00();
      }
    }
    
    private void InitMenu ( )
    {
      _menuIconImageView.Click += delegate
      {
        if ( !_isSingleTapFired )
        {
          MenuMostraEsconde ( );
          _isSingleTapFired = false;
        }
      };
      _btnDescExpander.Click += delegate
      {
        FiltroMostraEsconde ( );
      };
      MenuMonta ( );
    }

    private void InitTelaComponentes ( )
    {
      _gestureListener = new GestureListener ( );
      _gestureListener.LeftEvent += GestureLeft;
      _gestureListener.RightEvent += GestureRight;
      _gestureListener.SingleTapEvent += SingleTap;
      _gestureDetector = new GestureDetector ( this, _gestureListener );
      _menuListView = FindViewById<ListView> ( Resource.Id.menuListView );
      _menuIconImageView = FindViewById<ImageView> ( Resource.Id.menuIconImgView );
      _filtro = FindViewById<LinearLayout> ( Resource.Id.filtro );
      _filtro.Visibility = ViewStates.Gone;
      _btnDescExpander = FindViewById<ImageView> ( Resource.Id.btnImgExpander );
      var display = WindowManager.DefaultDisplay;
      var point = new Point ( );
      display.GetSize ( point );
      _intDisplayWidth = point.X;
      _intDisplayWidth = _intDisplayWidth / 3;
      using ( var layoutParams = ( RelativeLayout.LayoutParams )_menuListView.LayoutParameters )
      {
        layoutParams.Width = _intDisplayWidth;
        layoutParams.Height = ViewGroup.LayoutParams.MatchParent;
        _menuListView.LayoutParameters = layoutParams;
      }
    }

    private void InitTelaCampos()
    {
      _txtActionBarText = FindViewById<TextView> ( Resource.Id.txtActionBarText );
    }

    private void InitTela ( )
    {
      InitTelaComponentes();
      InitTelaCampos();
    }

    private void ObtemItemPopUp ( )
    {
      _itemAtual = FiltroItem.Item;
      InitConsulta00();
    }

    #region " Menu related"
    private void MenuMonta ( )
    {
      string[] strMnuText =
      {
        "Início"
      , "Dimensões"
      , "Manufatura"
      , "Planejamento"
      , "Fiscal"
      };
      int [] strMnuUrl =
      {
        Resource.Drawable.icon_home
      , Resource.Drawable.icon_product
      , Resource.Drawable.icon_event
      , Resource.Drawable.icon_service
      , Resource.Drawable.icon_client
      };
      if ( _objAdapterMenu != null )
      {
        _objAdapterMenu.ActionMenuSelected -= MenuOpcaoSelecionada;
        _objAdapterMenu = null;
      }
      _objAdapterMenu = new MenuListAdapterClass ( this, strMnuText, strMnuUrl );
      _objAdapterMenu.ActionMenuSelected += MenuOpcaoSelecionada;
      _menuListView.Adapter = _objAdapterMenu;
    }

    private void MenuOpcaoSelecionada ( string strMenuText )
    {
      _txtActionBarText.Text = strMenuText;
      //selected action goes here
    }

    private void MenuMostraEsconde ( )
    {
      Console.WriteLine ( _menuListView.IsShown );
      if ( _menuListView.IsShown )
      {
        _menuListView.Animation = new TranslateAnimation ( 0f, -_menuListView.MeasuredWidth, 0f, 0f )
        {
          Duration = 300
        };
        _menuListView.Visibility = ViewStates.Gone;
      }
      else
      {
        _menuListView.Visibility = ViewStates.Visible;
        _menuListView.RequestFocus ( );
        _menuListView.Animation = new TranslateAnimation ( -_menuListView.MeasuredWidth, 0f, 0f, 0f )
        {
          Duration = 300
        }; //starting edge of layout 
      }
    }
    #endregion

    #region "Gesture function "

    private void GestureLeft ( )
    {
      if (!_menuListView.IsShown)
      {
        MenuMostraEsconde ( );
      }
      _isSingleTapFired = false;
    }

    private void GestureRight ( )
    {
      if (_menuListView.IsShown)
      {
        MenuMostraEsconde ( );
      }
      _isSingleTapFired = false;
    }

    private void SingleTap ( )
    {
      if ( _menuListView.IsShown )
      {
        MenuMostraEsconde ( );
        _isSingleTapFired = true;
      }
      else
      {
        _isSingleTapFired = false;
      }
    }

    public override bool DispatchTouchEvent ( MotionEvent ev )
    {
      _gestureDetector.OnTouchEvent ( ev );
      return base.DispatchTouchEvent ( ev );
    }
    #endregion

    #region "Filtro toggle window"

    private void FiltroMostraEsconde ( )
    {
      if ( _filtro.IsShown )
      {
        _filtro.Visibility = ViewStates.Gone;
        _filtro.Animation = new TranslateAnimation
        (
          Dimension.RelativeToSelf
        , 0.0f
        , Dimension.RelativeToSelf
        , 0.0f
        , Dimension.RelativeToSelf
        , 0.0f
        , Dimension.RelativeToParent
        , -1.0f
        )
        {
          Duration = 500
        };
        _btnDescExpander.SetImageResource ( Resource.Drawable.down_arrow );
      }
      else
      {
        FiltroItem.Limpar();
        _filtro.Visibility = ViewStates.Visible;
        _filtro.RequestFocus ( );
        _filtro.Animation = new TranslateAnimation
        (
          Dimension.RelativeToSelf
        , 0.0f
        , Dimension.RelativeToSelf
        , 0.0f
        , Dimension.RelativeToParent
        , -1.0f
        , Dimension.RelativeToSelf
        , 0.0f
        )
        {
          Duration = 500
        };
        _btnDescExpander.SetImageResource ( Resource.Drawable.up_arrow );
      }
    
    }
    #endregion
  }

  #region " Menu list adapter"

  public class MenuListAdapterClass : BaseAdapter<string>
  {
    readonly Activity _context;
    readonly string[] _mnuText;
    readonly int[] _mnuUrl;
    internal event Action<string> ActionMenuSelected;

    public MenuListAdapterClass ( Activity context, string [ ] strMnu, int [ ] intImage )
    {
      _context = context;
      _mnuText = strMnu;
      _mnuUrl = intImage;
    }

    public override string this [ int position ]
    {
      get
      {
        return _mnuText [ position ];
      }
    }

    public override int Count
    {
      get
      {
        return _mnuText.Length;
      }
    }

    public override long GetItemId ( int position )
    {
      return position;
    }

    public override View GetView ( int position, View convertView, ViewGroup parent )
    {
      MenuListViewHolderClass objMenuListViewHolderClass;
      var view = convertView;
      if ( view == null )
      {
        view = _context.LayoutInflater.Inflate ( Resource.Layout.MenuCustomLayout, parent, false );
        objMenuListViewHolderClass = new MenuListViewHolderClass
        {
          TxtMnuText = view.FindViewById<TextView> ( Resource.Id.txtMnuText )
        , IvMenuImg = view.FindViewById<ImageView> ( Resource.Id.ivMenuImg )
        };
        objMenuListViewHolderClass.Initialize ( view );
        view.Tag = objMenuListViewHolderClass;
      }
      else
      {
        objMenuListViewHolderClass = ( MenuListViewHolderClass )view.Tag;
      }
      objMenuListViewHolderClass.ViewClicked = ( ) =>
      {
        if ( ActionMenuSelected != null )
        {
          ActionMenuSelected ( _mnuText [ position ] );
        }
      };
      objMenuListViewHolderClass.TxtMnuText.Text = _mnuText [ position ];
      objMenuListViewHolderClass.IvMenuImg.SetImageResource ( _mnuUrl [ position ] );
      return view;
    }
  }

  internal class MenuListViewHolderClass : Java.Lang.Object
  {
    internal Action ViewClicked
    {
      private get;
      set;
    }
    internal TextView TxtMnuText;
    internal ImageView IvMenuImg;

    public void Initialize ( View view )
    {
      view.Click += delegate
      {
        ViewClicked ( );
      };
    }

  }

  #endregion
}


