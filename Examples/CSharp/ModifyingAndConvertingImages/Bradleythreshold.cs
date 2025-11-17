// GIST-ID: 2678a105d937f208697c6ba25c1e6922
using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Bmp;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class Bradleythreshold
    {
        public static void Run()
        {
            Console.WriteLine("Running example Bradleythreshold");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages() + "sample.bmp";

            // Load an existing image.
            using (var objimage = (BmpImage)Image.Load(dataDir))
            {
                // Define the threshold value, call BinarizeBradley method and pass the threshold value as a parameter, then save the output image.
                double threshold = 0.15;
                objimage.BinarizeBradley(threshold);
                objimage.Save(dataDir + "binarized_out.png");
            }

            Console.WriteLine("Finished example Bradleythreshold");
        }
    }
}