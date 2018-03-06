using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class AddSignatureToImage
    {
        public static void Run()
        {
            //ExStart:AddSignatureToImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Create an instance of Image and load the primary image
            using (Image canvas = Image.Load(dataDir + "SampleTiff1.tiff"))
            {
                // Create another instance of Image and load the secondary image containing the signature graphics
                using (Image signature = Image.Load(dataDir + "signature.gif"))
                {
                    // Create an instance of Graphics class and initialize it using the object of the primary image
                    Graphics graphics = new Graphics(canvas);

                    // Call the DrawImage method while passing the instance of secondary image and appropriate location. The following snippet tries to draw the secondary image at the right bottom of the primary image
                    graphics.DrawImage(signature, new Point(canvas.Height - signature.Height, canvas.Width - signature.Width));
                    canvas.Save(dataDir + "AddSignatureToImage_out.png", new PngOptions());
                }
            }
            //ExStart:AddSignatureToImage
        }
    }
}