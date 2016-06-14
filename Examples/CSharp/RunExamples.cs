using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aspose.Imaging.Examples.CSharp.Export;
using Aspose.Imaging.Examples.CSharp.Files;
using Aspose.Imaging.Examples.CSharp.Images;
using Aspose.Imaging.Examples.CSharp.Shapes;

namespace Aspose.Imaging.Examples.CSharp
{
    class RunExamples
    {


        static void Main()
        {

            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the one you want to try out

            //// =====================================================
            //// =====================================================
            //// Export
            //// =====================================================
            //// =====================================================

            //ExportDxfToPdf.Run();
            //ExportImageToDifferentFormats.Run();
            //ExportImageToPSD.Run();
            //ExportPsdLayersToImages.Run();

            //// =====================================================
            //// =====================================================
            //// Files
            //// =====================================================
            //// =====================================================

            //CreatingAnImageBySettingPath.Run();
            //CreatingImageUsingStream.Run();

            //// =====================================================
            //// =====================================================
            //// Images
            //// =====================================================
            //// =====================================================

            //AddFramesToTIFFImage.Run();
            //ConcatTIFFImages.Run();
            //DrawImagesUsingCoreFunctionality.Run();
            //DrawingUsingGraphicsPath.Run();

            //// =====================================================
            //// =====================================================
            //// Shapes
            //// =====================================================
            //// =====================================================

            //DrawingArc.Run();
            //DrawingBezier.Run();
            //DrawingEllipse.Run();
            //DrawingLines.Run();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static String GetDataDir_Export(string path)
        {
            return Path.GetFullPath(GetDataDir_Data() + "Export/" + path + "/");
        }

        public static String GetDataDir_Files()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Files/");
        }

        public static String GetDataDir_Images(string path)
        {
            return Path.GetFullPath(GetDataDir_Data() + "Images/" + path + "/");
        }

        public static String GetDataDir_Shapes(string path)
        {
            return Path.GetFullPath(GetDataDir_Data() + "Shapes/" + path + "/");
        }


        public static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return Path.Combine(startDirectory, "Data\\");
        }

    }
}
