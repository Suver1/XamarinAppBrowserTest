using GalaSoft.MvvmLight.Ioc;
using BrowserTest.Lib;
using System;
namespace BrowserTest
{
	public class ViewModelLocator : Lib.ViewModel.ViewModelLocator
	{
		public ViewModelLocator()
		{
			SimpleIoc.Default.Register<ISystemInformationHandler, SystemInformationHandler>();
		}
	}
}
