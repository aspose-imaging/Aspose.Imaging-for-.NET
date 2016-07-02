using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    class CombineImages
    {
        public static void Run()
        {
            // ExStart:CombineImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Create an instance of JpegOptions and set its various properties
            JpegOptions imageOptions = new JpegOptions();

            // Create an instance of FileCreateSource and assign it to Source property
            imageOptions.Source = new FileCreateSource(dataDir + "Two_images_result_out.bmp", false);

            // Create an instance of Image and define canvas size
            using (var image = Image.Create(imageOptions, 600, 600))
            {
                // Create and initialize an instance of Graphics
                var graphics = new Graphics(image);

                // Clear the image surface with white color
                graphics.Clear(Color.White);

                // Draw Image
                graphics.DrawImage(Image.Load(dataDir + "SampleImage_out.bmp"), 0, 0, 600, 300);
                graphics.DrawImage(Image.Load(dataDir + "File1.bmp"), 0, 300, 600, 300);

                // Call save method to save the resultant image.
                image.Save();
            }
            // ExEnd:CombineImages
        }
    }
}
