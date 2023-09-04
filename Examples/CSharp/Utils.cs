using System;
using System.IO;

namespace Aspose.Imaging.Examples
{
	class Utils
    {
        public static string GetDataDir(Type t)
        {
            string c = t.FullName;
            c = c.Replace("Aspose.Imaging.Examples.", "");
            c = c.Replace('.', Path.DirectorySeparatorChar);
            string p = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Data", c));
            p += Path.DirectorySeparatorChar;
            Console.WriteLine("Using Data Dir {0}", p);
            return p;
        }

        //static void Main()
        //{

        //    Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
        //    Console.WriteLine("=====================================================");

        //    // Uncomment the one you want to try out
         
        //    //// =====================================================
        //    //// =====================================================
        //    //// Export
        //    //// =====================================================
        //    //// =====================================================

        //    //ExportDxfToPdf.Run();
        //    //ExportImageToDifferentFormats.Run();
        //    //ExportImageToPSD.Run();
        //    //ExportPsdLayersToImages.Run();

        //    //// =====================================================
        //    //// =====================================================
        //    //// Files
        //    //// =====================================================
        //    //// =====================================================

        //    //CreatingAnImageBySettingPath.Run();
        //    //CreatingImageUsingStream.Run();

        //    //// =====================================================
        //    //// =====================================================
        //    //// Images
        //    //// =====================================================
        //    //// =====================================================

        //    //AddFramesToTIFFImage.Run();
        //    //ConcatTIFFImages.Run();
        //    //DrawImagesUsingCoreFunctionality.Run();
        //    //DrawingUsingGraphicsPath.Run();

        //    //// =====================================================
        //    //// =====================================================
        //    //// Shapes
        //    //// =====================================================
        //    //// =====================================================

        //    //DrawingArc.Run();
        //    //DrawingBezier.Run();
        //    //DrawingEllipse.Run();
        //    //DrawingLines.Run();

        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();
        //}
    }
}
