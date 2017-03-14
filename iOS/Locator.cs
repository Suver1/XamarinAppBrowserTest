using System;
using System.Threading;
using BrowserTest.Lib;
using GalaSoft.MvvmLight.Ioc;

namespace BrowserTest.iOS
{
	internal class Locator : ViewModelLocator
	{
		private static Lazy<Locator> _locator = new Lazy<Locator>(() => new Locator(), LazyThreadSafetyMode.PublicationOnly);
		public static Locator Instance => _locator.Value;

		private Locator()
		{
			SimpleIoc.Default.Unregister<ISystemInformationHandler>();
			SimpleIoc.Default.Register<ISystemInformationHandler, SystemInformationHandler>();
		}
	}
}
