using Aspose.Imaging.FileFormats.Bmp;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class Bradleythreshold
    {
        public static void Run()
        {
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            // ExStart:Bradleythreshold
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages() + "sample.bmp";

            // Load an existing image.
            using (var objimage = (BmpImage)Image.Load(dataDir))
            {
                // Define threshold value
                double threshold = 0.15;

                // Call BinarizeBradley method and pass the threshold value as parameter
                objimage.BinarizeBradley(threshold);

                // Save the output image
                objimage.Save(dataDir + "binarized_out.png");
            }
            // ExEnd:Bradleythreshold
        }
    }
}
