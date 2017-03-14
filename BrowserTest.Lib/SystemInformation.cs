using System;
namespace BrowserTest.Lib
{
	public class SystemInformation
	{
		private readonly ISystemInformationHandler _systemInformationHandler;
		public SystemInformation(ISystemInformationHandler systemInformationHandler)
		{
			if (systemInformationHandler == null) throw new ArgumentNullException(nameof(systemInformationHandler));
			_systemInformationHandler = systemInformationHandler;
			OSVersion = _systemInformationHandler.OSVersion;
		}

		public string OSVersion { get; }
	}
}
