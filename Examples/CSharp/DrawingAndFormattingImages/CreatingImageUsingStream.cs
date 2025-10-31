using System;
using System.IO;
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
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

            // Create an instance of BmpOptions and set its various properties.
            BmpOptions ImageOptions = new BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            // Create an instance of System.IO.Stream.
            Stream stream = new FileStream(dataDir + "sample_out.bmp", FileMode.Create);

            // Define the source property for the instance of BmpOptions.
            // The boolean parameter determines whether the stream is disposed when it goes out of scope.
            ImageOptions.Source = new StreamSource(stream, true);

            // Create an instance of Image and call the Create method by passing the BmpOptions object.
            using (Image image = Image.Create(ImageOptions, 500, 500))
            {
                // Do some image processing.
                image.Save(dataDir + "CreatingImageUsingStream_out.bmp");
            }

            Console.WriteLine("Finished example CreatingImageUsingStream");
        }
    }
}