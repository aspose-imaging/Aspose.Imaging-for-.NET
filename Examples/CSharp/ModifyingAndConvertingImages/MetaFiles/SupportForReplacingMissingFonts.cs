using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
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

			string[] files = new string[] { "missing-font.emf", "missing-font.odg", "missing-font.svg", "missing-font.wmf" };
			VectorRasterizationOptions[] options = new VectorRasterizationOptions[] { new EmfRasterizationOptions(), new OdgRasterizationOptions(), new SvgRasterizationOptions(), new WmfRasterizationOptions() };

			for (int i = 0; i < files.Length; i++)
			{
				string outFile = files[i] + ".png";
				using (Image img = Image.Load(files[i]))
				{
					options[i].PageWidth = img.Width;
					options[i].PageHeight = img.Height;
					img.Save(outFile, new PngOptions()
					{
						VectorRasterizationOptions = options[i]
					});
				}

			}


			//ExEnd:SupportForReplacingMissingFonts
		}
	}
}