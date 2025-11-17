// GIST-ID: d0faab2a62cd2c1bb5aba0596f911772
using System;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project.
For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ExportRasterImageToSvg
    {
        public static void Run()
        {
            // ExStart:ExportRasterImageToSvg
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            string[] paths = new string[]
            {
                @"C:\test\butterfly.gif",
                @"C:\test\33715-cmyk.jpeg",
                @"C:\test\3.JPG",
                @"C:\test\test.j2k",
                @"C:\test\Rings.png",
                @"C:\test\3layers_maximized_comp.psd",
                @"C:\test\img4.TIF",
                @"C:\test\Lossy5.webp"
            };

            foreach (string path in paths)
            {
                string destPath = path + ".svg";

                using (Image image = Image.Load(path))
                {
                    SvgOptions svgOptions = new SvgOptions();
                    SvgRasterizationOptions svgRasterizationOptions = new SvgRasterizationOptions();
                    svgOptions.VectorRasterizationOptions = svgRasterizationOptions;
                    svgOptions.VectorRasterizationOptions.PageWidth = image.Width;
                    svgOptions.VectorRasterizationOptions.PageHeight = image.Height;

                    image.Save(destPath, svgOptions);
                }
            }
            // ExEnd:ExportRasterImageToSvg
        }
    }
}