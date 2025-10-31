using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.FileFormats.Emf.Emf.Consts;
using Aspose.Imaging.FileFormats.Emf.Emf.Objects;
using Aspose.Imaging.FileFormats.Emf.Emf.Records;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.Fonts
{
    internal class SpecifyFont
    {
        public static void Run()
        {
            Console.WriteLine("Running example SpecifyFont");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Fonts();

            string baseFolder = dataDir;
            const string fontName = "Cambria Math";
            const int symbolCount = 40; // count symbols in the example
            const int startIndex = 2001; // start GlyphIndex for the example
            string fontFolder = baseFolder; // font folder
            FontSettings.SetFontsFolder(fontFolder);

            // Fill GlyphIndex buffer
            var glyphCodes = new int[symbolCount];
            for (int i = 0; i < symbolCount; i++)
            {
                glyphCodes[i] = startIndex + i;
            }

            // Create EMF
            using (EmfImage emf = new EmfImage(700, 100))
            {
                // Font record
                var font = new EmfExtCreateFontIndirectW();
                font.Elw = new EmfLogFont();
                font.Elw.Facename = fontName;
                font.Elw.Height = 30;

                // Text record
                var text = new EmfExtTextOutW();
                text.WEmrText = new EmfText();
                text.WEmrText.Options = EmfExtTextOutOptions.ETO_GLYPH_INDEX; // symbols index as GlyphIndex
                text.WEmrText.Chars = symbolCount; // string length
                text.WEmrText.GlyphIndexBuffer = glyphCodes; // index buffer

                emf.Records.Add(font); // add font
                emf.Records.Add(new EmfSelectObject()
                {
                    ObjectHandle = 0
                }); // select font
                emf.Records.Add(text); // add text
                emf.Save(Path.Combine(baseFolder, "result.png")); // rendering
            }

            File.Delete(Path.Combine(baseFolder, "result.png"));

            Console.WriteLine("Finished example SpecifyFont");
        }
    }
}