using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging;
namespace CSharp.ModifyingAndConvertingImages
{
	class RasterImageToPDF
	{
		public static void Run()
	 {
			//ExStart:RasterImageToPDF
			string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
		
            string destFilePath = "transparent_orig.gif.pdf";
			using (Image image = Image.Load(dataDir+ "transparent_orig.gif"))
			{
				image.Save(dataDir+destFilePath, new PdfOptions());

				//ExEnd:RasterImageToPDF
			}
		    }
		}
	}


