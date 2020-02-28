using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.MetaFiles
{
	class SupportForReplacingMissingFonts
	{
		public static void Run()
		{

			//ExStart:SupportForReplacingMissingFonts
			// The path to the documents directory.
			string dataDir = RunExamples.GetDataDir_MetaFiles();

			FontSettings.DefaultFontName = "Comic Sans MS";

            string[] files = new string[] { "Fonts.emf" };
			VectorRasterizationOptions[] options = new VectorRasterizationOptions[] { new EmfRasterizationOptions(), new OdgRasterizationOptions(), new SvgRasterizationOptions(), new WmfRasterizationOptions() };

            Console.WriteLine("Running example SupportForReplacingMissingFonts");

			for (int i = 0; i < files.Length; i++)
			{
				string outFile = files[i] + ".png";
				using (Image img = Image.Load(Path.Combine(dataDir, files[i])))
				{
					options[i].PageWidth = img.Width;
					options[i].PageHeight = img.Height;
					img.Save(outFile, new PngOptions()
					{
						VectorRasterizationOptions = options[i]
					});
				}

			}

		    Console.WriteLine("Finished example SupportForReplacingMissingFonts");
			//ExEnd:SupportForReplacingMissingFonts
		}
	}
}