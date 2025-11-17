// GIST-ID: de1271a2dd80bf8214dcb38bf27a91a7
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG
{
    class CompressingFiles
    {
        public static void Run()
        {
            Console.WriteLine("Running example CompressingFiles");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            // Load an image from a file (or stream)
            using (Image image = Image.Load(dataDir + "aspose_logo.png"))
            {
                // Loop over possible CompressionLevel range
                for (int i = 0; i <= 9; i++)
                {
                    // Create an instance of PngOptions for each resultant PNG, set CompressionLevel, and save the result on disk
                    PngOptions options = new PngOptions();
                    options.CompressionLevel = i;
                    image.Save(i + "_out.png", options);
                }
            }

            Console.WriteLine("Finished example CompressingFiles");
        }
    }
}