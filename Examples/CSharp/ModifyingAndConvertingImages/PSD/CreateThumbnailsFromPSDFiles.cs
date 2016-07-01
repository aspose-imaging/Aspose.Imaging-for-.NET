using Aspose.Imaging.FileFormats.Bmp;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.FileFormats.Psd.Resources;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PSD
{
    class CreateThumbnailsFromPSDFiles
    {
        public static void Run()
        {
            // ExStart:CreateThumbnailsFromPSDFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            // Load a PSD in an instance of PsdImage
            using (PsdImage image = (PsdImage)Image.Load(dataDir + "sample.psd"))
            {
                // Iterate over the PSD resources
                foreach (var resource in image.ImageResources)
                {
                    // Check if the resource is of thumbnail type
                    if (resource is ThumbnailResource)
                    {
                        // Retrieve the ThumbnailResource
                        var thumbnail = (ThumbnailResource)resource;
                        // Check the format of the ThumbnailResource
                        if (thumbnail.Format == ThumbnailFormat.KJpegRgb)
                        {
                            // Create a new BmpImage by specifying the width and heigh
                            BmpImage thumnailImage = new BmpImage(thumbnail.Width, thumbnail.Height);
                            // Store the pixels of thumbnail on to the newly created BmpImage
                            thumnailImage.SavePixels(thumnailImage.Bounds, thumbnail.ThumbnailData);
                            // Save thumbnail on disc
                            thumnailImage.Save(dataDir + "CreateThumbnailsFromPSDFiles_out.bmp");
                        }
                    }
                }
            }
            // ExEnd:CreateThumbnailsFromPSDFiles
        }
    }
}