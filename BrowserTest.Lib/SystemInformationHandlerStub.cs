using System;
namespace BrowserTest.Lib.ViewModel
{
	public class SystemInformationHandlerStub : ISystemInformationHandler
	{
		#region Implementation of ISystemInformationHandler

		public string OSVersion => "The Design OS Version";

		#endregion
	}
}
