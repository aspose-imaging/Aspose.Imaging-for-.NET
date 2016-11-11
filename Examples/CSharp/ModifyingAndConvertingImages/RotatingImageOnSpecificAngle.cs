/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class RotatingImageOnSpecificAngle
    {
        public static void Run()
        {
            // ExStart:RotatingImageOnSpecificAngle
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
          
            // Load an image to be rotated in an instance of RasterImage
            using (RasterImage image = (RasterImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Before rotation, the image should be cached for better performance
                if (!image.IsCached)
                {
                    image.CacheData();
                }
                // Perform the rotation on 20 degree while keeping the image size proportional with red background color and Save the result to a new file
                image.Rotate(20f, true, Color.Red);
                image.Save(dataDir + "RotatingImageOnSpecificAngle_out.jpg");
            }

            // ExEnd:RotatingImageOnSpecificAngle
        }
    }
}