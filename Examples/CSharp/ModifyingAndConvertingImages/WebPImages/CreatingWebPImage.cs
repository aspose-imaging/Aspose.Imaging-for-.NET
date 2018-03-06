using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.WebPImages
{
    class CreatingWebPImage
    {
        public static void Run()
        {
            //ExStart:CreatingWebPImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WebPImages();

            // Create an instance of WebPOptions class and set properties
            WebPOptions imageOptions = new WebPOptions();
            imageOptions.Lossless = true;
            imageOptions.Source = new FileCreateSource(dataDir + "CreatingWebPImage_out.webp", false);

            // Create an instance of image class by using WebOptions instance that you have just created.
            using (Image image = Image.Create(imageOptions, 500, 500))
            {
                image.Save();
            }
            //ExEnd:CreatingWebPImage
        }
    }
}