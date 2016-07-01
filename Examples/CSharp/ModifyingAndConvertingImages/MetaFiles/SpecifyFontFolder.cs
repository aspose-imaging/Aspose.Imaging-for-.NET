using System.Collections.Generic;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class SpecifyFontFolder
    {
        public static void Run()
        {
            // ExStart:SpecifyFontFolder
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MetaFiles();

            // create an instance of Rasterization options
            EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();
            emfRasterizationOptions.BackgroundColor = Color.WhiteSmoke;

            // create an instance of PNG options
            PngOptions pngOptions = new PngOptions();
            pngOptions.VectorRasterizationOptions = emfRasterizationOptions;

            // load an existing EMF image
            using (EmfImage image = (EmfImage)Image.Load(dataDir + "Picture1.emf"))
            {
                image.CacheData();

                // set heigh and width 
                pngOptions.VectorRasterizationOptions.PageWidth = 300;
                pngOptions.VectorRasterizationOptions.PageHeight = 350;

                // reset font settings
                FontSettings.Reset();
                image.Save(dataDir + "Picture1_default_fonts_out.png", pngOptions);

                // initialize font list
                List<string> fonts = new List<string>(FontSettings.GetDefaultFontsFolders());

                // add new font path to font list
                fonts.Add(dataDir + "arialAndTimesAndCourierRegular.xml");

                // assign list of font folders to font settings
                FontSettings.SetFontsFolders(fonts.ToArray(), true);

                // save the EMF file to PNG image with new font
                image.Save(dataDir + "Picture1_with_my_fonts_out.png", pngOptions);
            }
        }
        // ExEnd:SpecifyFontFolder
    }
}