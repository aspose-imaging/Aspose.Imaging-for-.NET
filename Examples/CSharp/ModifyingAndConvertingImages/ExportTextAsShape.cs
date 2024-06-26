﻿using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ExportTextAsShape
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportTextAsShape");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            using (Image image = Image.Load(dataDir + "Picture1.emf"))
            {
                EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();
                emfRasterizationOptions.BackgroundColor = Color.White;
                emfRasterizationOptions.PageWidth = image.Width;
                emfRasterizationOptions.PageHeight = image.Height;
                image.Save(dataDir + "TextAsShapes_out.svg", new SvgOptions
                {
                    VectorRasterizationOptions = emfRasterizationOptions,
                    TextAsShapes = true
                });

                image.Save(dataDir + "TextAsShapesFalse_out.svg", new SvgOptions
                {
                    VectorRasterizationOptions = emfRasterizationOptions,
                    TextAsShapes = false
                });
            }

            Console.WriteLine("Finished example ExportTextAsShape");
        }
    }
}