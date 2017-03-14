using System;
using BrowserTest.Lib;

namespace BrowserTest.Droid
{
	internal class SystemInformationHandler : ISystemInformationHandler
	{
		#region Implementation of ISystemInformationHandler

		public string OSVersion => $"Android {Android.OS.Build.VERSION.SdkInt} {Android.OS.Build.VERSION.Release}";

		#endregion
	}
}
