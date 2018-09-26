using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
	class MultipleImagesToTIFF
	{
		public static void Run()
		{

			//ExStart:MultipleImagesToTIFF
			// The path to the documents directory.
			string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
			//String path = @"C:\Imaging Data\IMG\";
			int page = 0;
			var tempImage = Aspose.Imaging.Image.Load(dataDir + "Image1.png");
			int width = 500;
			int height = 500;
			width = tempImage.Width;
			height = tempImage.Height;
         	Aspose.Imaging.ImageOptions.TiffOptions tiffOptions = new Aspose.Imaging.ImageOptions.TiffOptions(TiffExpectedFormat.Default);
         	tiffOptions.Source = new Aspose.Imaging.Sources.FileCreateSource(dataDir+"MultiPage.tiff", false);

			//Create an instance of Image and initialize it with instance of BmpOptions by calling Create method
			using (TiffImage TiffImage = (TiffImage)Aspose.Imaging.Image.Create(tiffOptions, width, height))
			{
				//do some image processing
				DirectoryInfo di = new DirectoryInfo(dataDir);
				FileInfo[] files = di.GetFiles("*.img");
				int index = 0;
				foreach (var file in files)
				{
					using (Aspose.Imaging.Image inputImage = Aspose.Imaging.Image.Load(file.FullName))
					{

						inputImage.Resize(width, height, ResizeType.NearestNeighbourResample);
						//  var frame = TiffImage.ActiveFrame;
						if (index > 0)
						{
							var newframe = new TiffFrame(tiffOptions, width, height);
							TiffImage.AddFrame(newframe);
							int cnt = TiffImage.Frames.Count();
						}
						var frame = TiffImage.Frames[index];
						frame.SavePixels(frame.Bounds, ((RasterImage)inputImage).LoadPixels(inputImage.Bounds));

						index += 1;
					}
				}

				// save all changes
				TiffImage.Save(dataDir+"output.tiff");
			}

		}

		//ExEnd:MultipleImagesToTIFF
	}

}
