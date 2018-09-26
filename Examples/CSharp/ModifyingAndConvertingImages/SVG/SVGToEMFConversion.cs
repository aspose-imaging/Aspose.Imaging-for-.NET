using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.SVG
{
	class SVGToEMFConversion
	{
		public static void Run()
		{

			//ExStart:SVGToEMFConversion
			string dataDir = RunExamples.GetDataDir_SVG();
			string[] testFiles = new string[5]
		   {
			   "input.svg",
			   "juanmontoya_lingerie.svg",
			   "rg1024_green_grapes.svg",
			   "sample_car.svg",
			   "tommek_Car.svg"
		   };

			string basePath =dataDir+ "Svg";
			string outputPath = dataDir+Path.Combine(basePath, "output");

			if (!Directory.Exists(outputPath))
			{
				Directory.CreateDirectory(outputPath);
			}

			foreach (string fileName in testFiles)
			{
				string inputFileName = Path.Combine(basePath, fileName);
				string outputFileName = Path.Combine(outputPath, fileName + ".emf");
				using (Image image = Image.Load(inputFileName))
				{
					image.Save(outputFileName,
						new EmfOptions
						{
							VectorRasterizationOptions = new SvgRasterizationOptions
							{
								PageSize = image.Size
							}
						});
				}
			   }

			//ExEnd:SVGToEMFConversion
		}
	    }
	}