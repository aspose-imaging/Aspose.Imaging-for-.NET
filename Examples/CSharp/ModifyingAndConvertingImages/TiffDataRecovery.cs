// GIST-ID: 47aeaf68d2a2c1fb04894edd9c9bd287
/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

using System;
using Aspose.Imaging;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class TiffDataRecovery
    {
        public static void Run()
        {
            Console.WriteLine("Running example TiffDataRecovery");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Create an instance of LoadOptions and set its properties.
            LoadOptions loadOptions = new LoadOptions();
            loadOptions.DataRecoveryMode = DataRecoveryMode.ConsistentRecover;
            loadOptions.DataBackgroundColor = Color.Red;

            // Load a damaged image by passing the instance of LoadOptions.
            using (Image image = Image.Load(dataDir + "SampleTiff1.tiff", loadOptions))
            {
                // Do some work.
            }

            Console.WriteLine("Finished example TiffDataRecovery");
        }
    }
}