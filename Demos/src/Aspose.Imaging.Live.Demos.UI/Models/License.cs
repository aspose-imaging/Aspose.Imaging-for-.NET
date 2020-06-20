using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aspose.Imaging.Live.Demos.UI.Models
{
	///<Summary>
	/// License class to set apose products license
	///</Summary>
	public static class License
	{
		private static string _licenseFileName = "Aspose.Total.lic";


		///<Summary>
		/// SetAsposeImagingLicense method to Aspose.Words License
		///</Summary>
		public static void SetAsposeImagingLicense()
		{
			try
			{
				Aspose.Imaging.License acLic = new Aspose.Imaging.License();
				acLic.SetLicense(_licenseFileName);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		
		
	}
}
