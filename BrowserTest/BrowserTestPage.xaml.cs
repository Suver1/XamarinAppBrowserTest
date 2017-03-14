using Xamarin.Forms;
using System;

namespace BrowserTest
{
	public partial class BrowserTestPage : ContentPage
	{
		WebView webView;

		public BrowserTestPage()
		{
			InitializeComponent();

			webView = new WebView();
			webView.Source = "https://www.prisguide.no";

			// Accomodate iPhone status bar.
			Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

			webView.Navigating += (sender, ev) =>
			{
				if (ev.Url.Contains("prisguide.no/goto.php"))
				{
					try
					{
						var uri = new Uri(ev.Url);
						Device.OpenUri(uri);
					}
					catch (Exception e)
					{
						System.Diagnostics.Debug.WriteLine("Exception: " + e);
					}

					ev.Cancel = true;
				}
			};

			Content = webView;
		}
	}
}
