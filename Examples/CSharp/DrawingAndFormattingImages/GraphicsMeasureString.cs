//-----------------------------------------------------------------------------------------------------------
// <copyright file="GraphicsMeasureString.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="08.08.2021 15:34:03">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DrawingAndFormattingImages
{
    class GraphicsMeasureString
    {
        public static void Run()
        {
            Console.WriteLine("Running example GraphicsMeasureString");
            string dataDir = RunExamples.GetDataDir_JPEG();

            string filepath = Path.Combine(dataDir, "input.jpg");

            using (Image backgoundImage = Image.Load(filepath))
            {
                Graphics gr = new Graphics(backgoundImage);
                StringFormat format = new StringFormat();
                SizeF size = gr.MeasureString("Test", new Font("Arial", 10), SizeF.Empty, format);
            }

            Console.WriteLine("Finished example GraphicsMeasureString");
        }
    }
}
