using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ConvertEMFToWMF
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing EMF file as Image.
            using (Image image = Image.Load(dataDir + "Picture1.emf"))
            {
                // Call the Save method of Image class & Pass instance of WmfOptions class to Save method.
                var ops = image.GetDefaultOptions(null);
                var emfRasterization = ops.VectorRasterizationOptions as EmfRasterizationOptions;

                //EmfRasterizationOptions emfRasterization = new EmfRasterizationOptions();
                emfRasterization.BackgroundColor = Color.Yellow;
                emfRasterization.PageWidth = 100;
                emfRasterization.PageHeight = 100;
                emfRasterization.BorderX = 5;
                emfRasterization.BorderY = 10;
                
                image.Save(dataDir + "ConvertEMFToWMF_out.wmf", ops);
            }
        }
    }
}