using System;
using Aspose.Imaging.FileFormats.Tiff;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class AlignHorizontalAndVeticalResolutionsOfImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example AlignHorizontalAndVeticalResolutionsOfImage");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image and convert the image instance to TiffImage.
            using (TiffImage image = (TiffImage)Image.Load(dataDir + "SampleTiff1.tiff"))
            {
                // Call the align resolution method and save the results to the output path.
                image.AlignResolutions();
                image.Save(dataDir + "AlignHorizontalAndVeticalResolutionsOfImage_out.tiff");
                int framesCount = image.Frames.Length;
                for (int i = 0; i < framesCount; i++)
                {
                    TiffFrame frame = image.Frames[i];
                    // All resolutions after alignment must be equal.
                    Console.WriteLine(
                        "Horizontal and vertical resolutions are equal:" +
                        ((int)frame.VerticalResolution == (int)frame.HorizontalResolution));
                }
            }

            Console.WriteLine("Finished example AlignHorizontalAndVeticalResolutionsOfImage");
        }
    }
}