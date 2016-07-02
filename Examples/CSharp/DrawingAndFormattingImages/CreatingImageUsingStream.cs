using System.IO;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class CreatingImageUsingStream
    {
        public static void Run()
        {
            // ExStart:CreatingImageUsingStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Creates an instance of BmpOptions and set its various properties
            BmpOptions ImageOptions = new BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            // Create an instance of System.IO.Stream
            Stream stream = new FileStream(dataDir + "sample_out.bmp", FileMode.Create);

            // Define the source property for the instance of BmpOptions
            // Second boolean parameter determines if the Stream is disposed once get out of scope
            ImageOptions.Source = new StreamSource(stream, true);

            // Creates an instance of Image and call Create method by passing the BmpOptions object
            using (Image image = Image.Create(ImageOptions, 500, 500))
            {
                // Do some image processing
                image.Save(dataDir + "CreatingImageUsingStream_out.bmp");
            }
            // ExEnd:CreatingImageUsingStream
        }
    }
}