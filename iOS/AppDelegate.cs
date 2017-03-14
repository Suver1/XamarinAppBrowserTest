using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using BrowserTest.Lib.ViewModel;

namespace BrowserTest.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		private MainViewModel VM => Locator.Instance.Main;

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			var mainViewModel = new MainViewModel(new SystemInformationHandler());
			var os = VM.OSVersion;
			System.Diagnostics.Debug.WriteLine("os1: " + os);
			os = mainViewModel.OSVersion;
			System.Diagnostics.Debug.WriteLine("os2: " + os);

			return base.FinishedLaunching(app, options);
		}
	}
}
