using System;
using System.IO;
using Aspose.Imaging.FileFormats.Psd;
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

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PSD
{
    class MergePSDlayers
    {
        public static void Run()
        {
            // ExStart:MergePSDlayers
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();
            string sourceFileName = dataDir + "samplePsd.psd";

            // Load an existing PSD file as image
            using (Image image = Image.Load(sourceFileName))
            {
                // Convert the loaded image to PSDImage
                var psdImage = (PsdImage)image;

                // create a JPG file stream
                using (Stream stream = File.Create(sourceFileName.Replace("psd", "jpg")))
                {
                    // Create JPEG option class object
                    var jpgOptions = new JpegOptions();

                    // Set the source property to jpg file stream.
                    jpgOptions.Source = new StreamSource(stream);

                    // call the Save the method of PSDImage class to merge the layers and save it as jpg image.
                    psdImage.Save(stream, jpgOptions);
                }
            }
            // ExEnd:MergePSDlayers
        }
    }
}