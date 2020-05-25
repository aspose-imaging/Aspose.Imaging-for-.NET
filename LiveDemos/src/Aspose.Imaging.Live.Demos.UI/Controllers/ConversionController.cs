using Aspose.Imaging.Live.Demos.UI.Models.Common;
using Aspose.Imaging.Live.Demos.UI.Models;
using Aspose.Imaging.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Imaging.Live.Demos.UI.Controllers
{
	public class ConversionController : BaseController  
	{
		public override string Product => (string)RouteData.Values["product"];


		[HttpPost]
		public Response Conversion(string outputType)
		{
			Response response = null;
			if (Request.Files.Count > 0)
			{

				var _files = UploadFiles(Request);

				for (int i = 0; i < _files.Count; i++)
				{
					AsposeImagingConversion _asposeImagingConversion = new AsposeImagingConversion();
					response = _asposeImagingConversion.ConvertFile(_files[i].FileName, _files[i].FolderName, outputType);
				}

			}

			return response;			
				
		}

		

		public ActionResult Conversion()
		{
			var model = new ViewModel(this, "Conversion")
			{
				SaveAsComponent = true,
				SaveAsOriginal = false,
				MaximumUploadFiles = 1,
				ShowViewerButton = false,
				DropOrUploadFileLabel = Resources["DropOrUploadFile"]
			};

			return View(model);
		}
		

	}
}
