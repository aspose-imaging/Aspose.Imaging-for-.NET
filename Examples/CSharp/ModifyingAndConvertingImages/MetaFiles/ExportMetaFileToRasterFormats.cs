// GIST-ID: b092d582240c111d602e06c47c70c730
using Aspose.Imaging.CoreExceptions;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download the Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class ExportMetaFileToRasterFormats
    {
        public static void Run()
        {
            //ExStart:ExportMetaFileToRasterFormats
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MetaFiles();
            string outputfile = dataDir + "file_out";

            // Create an EmfRasterizationOptions instance and set its properties.
            EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();
            emfRasterizationOptions.BackgroundColor = Color.PapayaWhip;
            emfRasterizationOptions.PageWidth = 300;
            emfRasterizationOptions.PageHeight = 300;

            // Load an existing EMF file as an image and convert it to an EmfImage object.
            using (var image = (EmfImage)Image.Load(dataDir + "Picture1.emf"))
            {
                if (!image.Header.EmfHeader.Valid)
                {
                    throw new ImageLoadException(string.Format("The file {0} is not valid", dataDir + "Picture1.emf"));
                }

                // Convert EMF to BMP, GIF, JPEG, J2K, PNG, PSD, TIFF, and WebP.
                image.Save(outputfile + ".bmp", new BmpOptions { VectorRasterizationOptions = emfRasterizationOptions });
                image.Save(outputfile + ".gif", new GifOptions { VectorRasterizationOptions = emfRasterizationOptions });
                image.Save(outputfile + ".jpeg", new JpegOptions { VectorRasterizationOptions = emfRasterizationOptions });
                image.Save(outputfile + ".j2k", new Jpeg2000Options { VectorRasterizationOptions = emfRasterizationOptions });
                image.Save(outputfile + ".png", new PngOptions { VectorRasterizationOptions = emfRasterizationOptions });
                image.Save(outputfile + ".psd", new PsdOptions { VectorRasterizationOptions = emfRasterizationOptions });
                image.Save(outputfile + ".tiff", new TiffOptions(TiffExpectedFormat.TiffLzwRgb) { VectorRasterizationOptions = emfRasterizationOptions });
                image.Save(outputfile + ".webp", new WebPOptions { VectorRasterizationOptions = emfRasterizationOptions });
            }
            //ExEnd:ExportMetaFileToRasterFormats
        }
    }
}