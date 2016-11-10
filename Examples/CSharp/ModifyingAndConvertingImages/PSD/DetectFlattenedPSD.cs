using System;
using Aspose.Imaging.FileFormats.Psd;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PSD
{
    class DetectFlattenedPSD
    {
        public static void Run()
        {
            // ExStart:DetectFlattenedPSD
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            // Load a PSD file
            using (PsdImage image = (PsdImage)Image.Load(dataDir + "samplePsd.psd"))
            {
                // Do processing, Get the true value if PSD is flatten and false in case the PSD is not flatten.
                Console.WriteLine(image.IsFlatten);
            }
            // ExEnd:DetectFlattenedPSD
        }
    }
}