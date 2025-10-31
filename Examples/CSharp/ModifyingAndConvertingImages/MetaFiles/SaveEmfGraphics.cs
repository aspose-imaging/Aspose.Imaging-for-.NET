using System;
using System.IO;
using System.Drawing;
using Aspose.Imaging.CoreExceptions;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.FileFormats.Emf.Graphics;
using Aspose.Imaging.ImageOptions;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class SaveEmfGraphics
    {
        public static void Run()
        {
            //ExStart:SaveEmfGraphics
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MetaFiles();

            Console.WriteLine("Running example SaveEmfGraphics");

            EmfRecorderGraphics2D graphics = new EmfRecorderGraphics2D(
                new Rectangle(0, 0, 5000, 5000),
                new Size(5000, 5000),
                new Size(1000, 1000));
            {
                Font font = new Font("Arial", 10, FontStyle.Bold | FontStyle.Underline);
                graphics.DrawString(font.Name + " " + font.Size + " " + font.Style.ToString(), font, Color.Brown, 10, 10);
                graphics.DrawString("some text", font, Color.Brown, 10, 30);

                font = new Font("Arial", 24, FontStyle.Italic | FontStyle.Strikeout);
                graphics.DrawString(font.Name + " " + font.Size + " " + font.Style.ToString(), font, Color.Brown, 20, 50);
                graphics.DrawString("some text", font, Color.Brown, 20, 80);

                using (EmfImage image = graphics.EndRecording())
                {
                    var path = dataDir + @"Fonts.emf";
                    image.Save(path, new EmfOptions());
                }
            }

            Console.WriteLine("Finished example SaveEmfGraphics");
            //ExEnd:SaveEmfGraphics
        }
    }
}