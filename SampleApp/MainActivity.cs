using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Com.Crashlytics.Android;
using IO.Fabric.Sdk.Android;

namespace SampleApp
{
    [Activity(Label = "SampleApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Fabric.With(this, new Crashlytics());

            var button = FindViewById<Button>(Resource.Id.button1);

            button.Click += ButtonOnClick;
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException("UHU!");
        }
    }
}
