using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aspose.Imaging.Live.Demos.UI.Config;

namespace Aspose.Imaging.Live.Demos.UI.Models
{
	public class AnotherApp
	{
		public string ImageSource { get; set; }
		public string ImageAlt { get; set; }
		public string AppName { get; set; }
		public string Href { get; set; }

		public AnotherApp()
		{
			// Empty for inheritance
		}

		public AnotherApp(string product, string appName)
		{
			AppName = appName;
			Href = $"/{product}/{appName.ToLower()}";

			switch (product)
			{
				case "words":
				{
					ImageSource = $"/img/apps/aspose_{appName.ToLower()}-app.png";
					ImageAlt = $"Aspose.Words {AppName}";
					break;
				}
				case "pdf":
				{
					ImageSource = $"/img/apps/aspose_{appName.ToLower()}-app.png";
					ImageAlt = $"Aspose.PDF {AppName}";
					break;
				}
				default:
				{
					if (AppName == "OCR" && (product == "ocr"))
						ImageSource = @"../../img/ocr/ocr-recognize-48.png";
					else
						ImageSource =
							$"https://www.aspose.cloud/templates/asposeapp/images/products/logo/aspose_{appName.ToLower()}-app.png";
					ImageAlt = $"{AppName}";
					break;
				}
			}
		}
	}
}
