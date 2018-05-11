using System;
using System.Linq;
using Android.App;
using Android.Text;
using Android.Widget;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Lor0138.Classes.Comum;
using Lorenzetti;
using Lorenzetti.DB;

namespace Lor0138.Activities
{
  [
    Activity
    (
      Label = "Lor0138"
      , MainLauncher = true
      , Icon = "@drawable/icon"
    )
  ]

  public class ActMain : Activity
  {
    private GestureDetector      _gestureDetector;
    private GestureListener      _gestureListener;
    private ListView             _menuListView;
    private MenuListAdapterClass _objAdapterMenu;
    private ImageView            _menuIconImageView;
    private Int32                _intDisplayWidth;
    private Boolean              _isSingleTapFired;
    private TextView             _txtActionBarText;
    private ImageView            _btnDescExpander;
    private LinearLayout         _filtro;
    private Classes.Consultas.Consulta00.Classe _consulta00;

    protected override void OnCreate ( Bundle bundle )
    {
      base.OnCreate ( bundle );
      Window.RequestFeature ( WindowFeatures.NoTitle );
      SetContentView ( Resource.Layout.Main );
      AppInit ( );
      TapEvent ( );
      MenuMonta ( );
    }

    private void TapEvent ( )
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
    }

    private void AppInitComponentes ( )
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

    private void AppInitCampos()
    {
      _txtActionBarText = FindViewById<TextView> ( Resource.Id.txtActionBarText );
    }

    private void AppInit ( )
    {
      AppInitComponentes();
      AppInitCampos();
      _consulta00 = new Classes.Consultas.Consulta00.Classe
      (
        new Config
        (
          eAmbiente.Desenvolvimento
        , eClientBanco.SQLServer
        , eBanco.sqlloren
        )
      , new AcessoSql
        (
          AcessoSql.AcessoTipo.Desenvolvimento
        )
      , this
      , "10"
      );
    }

    #region " Menu related"
    private void MenuMonta ( )
    {
      string[] strMnuText = { "Home", "AboutUs", "Products", "Events", "Serivce", "Clients", "Help", "Solution", "ContactUs" };
      int [] strMnuUrl= { Resource.Drawable.icon_home, Resource.Drawable.icon_aboutus, Resource.Drawable.icon_product, Resource.Drawable.icon_event, Resource.Drawable.icon_service, Resource.Drawable.icon_client, Resource.Drawable.icon_help, Resource.Drawable.icon_solution, Resource.Drawable.icon_contactus };
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

    #region "Description toggle window"

    private void FiltroMostraEsconde ( )
    {
      if ( _filtro.IsShown )
      {
        _filtro.Visibility = ViewStates.Gone;
        _filtro.Animation = new TranslateAnimation ( 0f, 0f, 0f, _filtro.MeasuredHeight )
        {
          Duration = 300
        };
        _btnDescExpander.SetImageResource ( Resource.Drawable.up_arrow );
      }
      else
      {
        _filtro.Visibility = ViewStates.Visible;
        _filtro.RequestFocus ( );
        _filtro.Animation = new TranslateAnimation ( 0f, 0f, _filtro.MeasuredHeight, 0f )
        {
          Duration = 300
        };
        _btnDescExpander.SetImageResource ( Resource.Drawable.down_arrow );
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
        return _mnuText.Count ( );
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


