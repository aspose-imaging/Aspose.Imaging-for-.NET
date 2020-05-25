using Aspose.Imaging.Live.Demos.UI.Models.Common;
using Aspose.Imaging.Live.Demos.UI.Models;
using Aspose.Imaging.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Imaging.Live.Demos.UI.Controllers
{
	public class WatermarkController : BaseController  
	{
		public override string Product => (string)RouteData.Values["product"];


		[HttpPost]
		public Response Watermark(string watermarkText, string watermarkColor, string outputType)
		{
			Response response = null;
			if (Request.Files.Count > 0)
			{

				var _files = UploadFiles(Request);

				for (int i = 0; i < _files.Count; i++)
				{
					AsposeImagingWatermark _asposeImagingWatermark = new AsposeImagingWatermark();
					response = _asposeImagingWatermark.AddWatermark(_files[i].FileName, _files[i].FolderName, watermarkText, outputType, watermarkColor);
				}

			}

			return response;				
		}
		public ActionResult Watermark()
		{
			
			var model = new ViewModel(this, "Watermark")
			{
				SaveAsComponent = true,
				SaveAsOriginal = false,
				ControlsView = "WatermarkControls",
				MaximumUploadFiles = 1,
				DropOrUploadFileLabel = Resources["DropOrUploadFile"],
				ShowViewerButton = false
			};
			if (model.RedirectToMainApp)
				return Redirect("/imaging/" + model.AppName.ToLower());
			return View(model);			
		}	

	}
}
