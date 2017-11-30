using System;
using System.IO;
using ImageOptions;
using Imaging.FileFormats.Svg;

internal class SvgFontTester
{
     
    #region Constants
   
    private const string FontFolderName = "fonts";
    private const string OutFolderName = "Out";
    private const string SourceFolder = @"D:\FontTests";
    private static readonly string OutFolder = Path.Combine(SourceFolder, OutFolderName);
    private static readonly string FontFolder = Path.Combine(OutFolder, FontFolderName);

    #endregion

    #region Methods

    public void ReadFileWithEmbeddedFontsAndExportToPdf()
    {
        this.ReadAndExportToPdf("EmbeddedFonts.svg");
    }

    public void ReadFileWithExportedFontsAndExportToPdf()
    {
        this.ReadAndExportToPdf("ExportedFonts.svg");
    }

    public void SaveWithEmbeddedFonts()
    {
        string[] files = new string[3]
            {
                "exportedFonts.svg", // File with exported fonts
                "embeddedFonts.svg", // File with embedded fonts
                "mysvg.svg" // simple file
            };

        for (int i = 0; i < files.Length; i++)
        {
            this.Save(true, files[i], 0);
        }
    }

    public void SaveWithExportFonts()
    {
        string[] files = new string[3]
            {
                "exportedFonts.svg", // File with exported fonts
                "embeddedFonts.svg", // File with embedded fonts
                "mysvg.svg" // simple file
            };

        int[] expectedFontsCount = new int[3] { 4, 4, 1 };

        for (int i = 0; i < files.Length; i++)
        {
            this.Save(false, files[i], expectedFontsCount[i]);
        }
    }

    private void ReadAndExportToPdf(string inputFileName)
    {
        if (!Directory.Exists(OutFolder))
        {
            Directory.CreateDirectory(OutFolder);
        }

        string inputFile = Path.Combine(SourceFolder, inputFileName);
        string outFile = Path.Combine(OutFolder, inputFileName + ".pdf");
        using (Image image = Image.Load(inputFile))
        {
            image.Save(outFile,
                new PdfOptions { VectorRasterizationOptions = new SvgRasterizationOptions { PageSize = image.Size } });
        }
    }

    private void Save(bool useEmbedded, string fileName, int expectedCountFonts)
    {
        if (!Directory.Exists(OutFolder))
        {
            Directory.CreateDirectory(OutFolder);
        }
        string fontStoreType = useEmbedded ? "Embedded" : "Stream";
        string inputFile = Path.Combine(SourceFolder, fileName);
        string outFileName = Path.GetFileNameWithoutExtension(fileName) + "_" + fontStoreType + ".svg";
        string outputFile = Path.Combine(OutFolder, outFileName);
        string fontFolder = string.Empty;
        using (Image image = Image.Load(inputFile))
        {
            EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();
            emfRasterizationOptions.BackgroundColor = Color.White;
            emfRasterizationOptions.PageWidth = image.Width;
            emfRasterizationOptions.PageHeight = image.Height;
            string testingFileName = Path.GetFileNameWithoutExtension(inputFile);
            fontFolder = Path.Combine(FontFolder, testingFileName);
            image.Save(outputFile,
                new SvgOptions
                {
                    VectorRasterizationOptions = emfRasterizationOptions,
                    Callback =
                        new SvgCallbackFontTest(useEmbedded, fontFolder)
                        {
                            Link = FontFolderName + "/" + testingFileName
                        }
                });
        }

        if (!useEmbedded)
        {
            string[] files = Directory.GetFiles(fontFolder);
            if (files.Length != expectedCountFonts)
            {
                throw new Exception(string.Format(
                    "Expected count font files = {0}, Current count font files = {1}", expectedCountFonts,
                    files.Length));
            }
        }
    }

    #endregion

    private class SvgCallbackFontTest : SvgResourceKeeperCallback
    {
        #region Fields

        /// <summary>
        ///     The out folder
        /// </summary>
        private readonly string outFolder;

        /// <summary>
        ///     The use embedded font
        /// </summary>
        private readonly bool useEmbeddedFont;

        /// <summary>
        /// The font counter
        /// </summary>
        private int fontCounter = 0;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SvgTests.SvgCallbackFontTest" /> class.
        /// </summary>
        /// <param name="useEbeddedFont">if set to <c>true</c> [use ebedded font].</param>
        /// <param name="outFolder">The out folder.</param>
        public SvgCallbackFontTest(bool useEbeddedFont, string outFolder)
        {
            this.useEmbeddedFont = useEbeddedFont;
            this.outFolder = outFolder;
            if (Directory.Exists(outFolder))
            {
                Directory.Delete(this.outFolder, true);
            }
        }

        #endregion

        #region Properties

        public string Link { get; set; }

        #endregion

        #region Methods

        /// <summary>
        ///     Called when font resource ready to be saved to storage.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns>
        ///     Returns path to saved resource. Path should be relative to target SVG document.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void OnFontResourceReady(FontStoringArgs args)
        {
            if (this.useEmbeddedFont)
            {
                args.FontStoreType = FontStoreType.Embedded;
            }
            else
            {
                args.FontStoreType = FontStoreType.Stream;
                string fontFolder = this.outFolder;
                if (!Directory.Exists(fontFolder))
                {
                    Directory.CreateDirectory(fontFolder);
                }

                string fName = args.SourceFontFileName;
                if (!File.Exists(fName))
                {
                    fName = string.Format("font_{0}.ttf", this.fontCounter++);
                }

                string fileName = fontFolder + @"\" + Path.GetFileName(fName);

                args.DestFontStream = new FileStream(fileName, FileMode.OpenOrCreate);
                args.DisposeStream = true;
                args.FontFileUri = "./" + this.Link + "/" + Path.GetFileName(fName);
            }
        }

        #endregion
    }
}
