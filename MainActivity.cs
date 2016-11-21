using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidFullScreen
{
    [Activity(Label = "AndroidFullScreen", MainLauncher = true, Icon = "@drawable/icon",
        Theme ="@android:style/Theme.Holo.Light.NoActionBar.Fullscreen")]
    public class MainActivity : Activity
    {
       
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

                  }
    }
}

