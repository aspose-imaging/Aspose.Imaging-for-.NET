using System.IO;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PSD
{
    class UncompressedImageStreamObject
    {
        public static void Run()
        {
            //ExStart:UncompressedImageStreamObject
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            // Create an instance of MemoryStream to hold the uncompressed image data.
            using (MemoryStream stream = new MemoryStream())
            {
                // First convert the image to raw PSD format.
                using (PsdImage psdImage = (PsdImage)Image.Load(dataDir + "PsdImage.psd"))
                {
                    PsdOptions saveOptions = new PsdOptions();
                    saveOptions.CompressionMethod = CompressionMethod.Raw;
                    psdImage.Save(dataDir + stream + "_out", saveOptions);
                }

                // Now reopen the newly created image.
                using (PsdImage psdImage = (PsdImage)Image.Load(dataDir + stream + "_out"))
                {
                    Graphics graphics = new Graphics(psdImage);
                    // Perform graphics operations.
                }
            }
            //ExEnd:UncompressedImageStreamObject
        }
    }
}