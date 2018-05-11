using Android.App;
using Android.OS;

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

  public class Lor0138 : Activity
  {
    protected override void OnCreate ( Bundle bundle )
    {
      base.OnCreate ( bundle );
      // Set our view from the "main" layout resource
      SetContentView ( Resource.Layout.lor0138 );
      var telaInicial = FindViewById<FlyOutContainer> ( Resource.Id.TelaInicial ) ;
      var btnMenuLateral = FindViewById ( Resource.Id.btnMenuLateral );
      btnMenuLateral.Click += ( sender, e ) =>
      {
        telaInicial.AnimatedOpened = !telaInicial.AnimatedOpened;
      };
    }
  }
}

