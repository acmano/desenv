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
      SetContentView ( Resource.Layout.Main );
      var menu = FindViewById<FlyOutContainer> ( Resource.Id.FlyOutContainer );
      var menuButton = FindViewById ( Resource.Id.MenuButton );
      menuButton.Click += ( sender, e ) =>
      {
        menu.AnimatedOpened = !menu.AnimatedOpened;
      };
    }
  }
}

