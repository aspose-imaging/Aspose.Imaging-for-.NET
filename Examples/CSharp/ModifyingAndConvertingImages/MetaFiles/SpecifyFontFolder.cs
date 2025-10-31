using System.Collections.Generic;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.ImageOptions;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class SpecifyFontFolder
    {
        public static void Run()
        {
            //ExStart:SpecifyFontFolder
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MetaFiles();

            // Create an instance of rasterization options.
            EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();
            emfRasterizationOptions.BackgroundColor = Color.WhiteSmoke;

            // Create an instance of PNG options.
            PngOptions pngOptions = new PngOptions();
            pngOptions.VectorRasterizationOptions = emfRasterizationOptions;

            // Load an existing EMF image.
            using (EmfImage image = (EmfImage)Image.Load(dataDir + "Picture1.emf"))
            {
                image.CacheData();

                // Set height and width, reset font settings.
                pngOptions.VectorRasterizationOptions.PageWidth = 300;
                pngOptions.VectorRasterizationOptions.PageHeight = 350;
                FontSettings.Reset();
                image.Save(dataDir + "Picture1_default_fonts_out.png", pngOptions);

                // Initialize font list.
                List<string> fonts = new List<string>(FontSettings.GetDefaultFontsFolders());

                // Add a new font path to the list, assign the list of font folders to the font settings, 
                // and save the EMF file to a PNG image with the new font.
                fonts.Add(dataDir + "arialAndTimesAndCourierRegular.xml");
                FontSettings.SetFontsFolders(fonts.ToArray(), true);
                image.Save(dataDir + "Picture1_with_my_fonts_out.png", pngOptions);
            }
            //ExEnd:SpecifyFontFolder
        }     
    }
}