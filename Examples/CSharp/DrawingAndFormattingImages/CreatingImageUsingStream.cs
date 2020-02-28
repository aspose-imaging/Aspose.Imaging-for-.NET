using System.IO;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class CreatingImageUsingStream
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreatingImageUsingStream");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Creates an instance of BmpOptions and set its various properties
            BmpOptions ImageOptions = new BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            // Create an instance of System.IO.Stream
            Stream stream = new FileStream(dataDir + "sample_out.bmp", FileMode.Create);

            // Define the source property for the instance of BmpOptions Second boolean parameter determines if the Stream is disposed once get out of scope
            ImageOptions.Source = new StreamSource(stream, true);

            // Creates an instance of Image and call Create method by passing the BmpOptions object
            using (Image image = Image.Create(ImageOptions, 500, 500))
            {
                // Do some image processing
                image.Save(dataDir + "CreatingImageUsingStream_out.bmp");
            }

            Console.WriteLine("Finished example CreatingImageUsingStream");
        }
    }
}