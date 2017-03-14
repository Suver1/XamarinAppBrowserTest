using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using BrowserTest.Lib.ViewModel;

namespace BrowserTest.Droid
{
	[Activity(Label = "BrowserTest.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{

		private MainViewModel VM => Locator.Instance.Main;

		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			var os = VM.OSVersion;
			System.Diagnostics.Debug.WriteLine("os: " + os);

			var mainViewModel = new MainViewModel(new SystemInformationHandler());
			os = mainViewModel.OSVersion;
			System.Diagnostics.Debug.WriteLine("os: " + os);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());
		}
	}
}
