using System;
using BrowserTest.Lib;
namespace BrowserTest
{
	internal class SystemInformationHandler : ISystemInformationHandler
	{
		public SystemInformationHandler()
		{
			/*string sv = AnalyticsInfo.VersionInfo.DeviceFamilyVersion;
			ulong v = ulong.Parse(sv);
			ulong v1 = (v & 0xFFFF000000000000L) >> 48;
			ulong v2 = (v & 0x0000FFFF00000000L) >> 32;
			ulong v3 = (v & 0x00000000FFFF0000L) >> 16;
			ulong v4 = (v & 0x000000000000FFFFL);

			OSVersion = $"Windows {v1}.{v2}.{v3}.{v4}";*/
			OSVersion = "hola";
		}

		public string OSVersion { get; }
	}
}
