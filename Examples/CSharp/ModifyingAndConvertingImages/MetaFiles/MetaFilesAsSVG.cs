using System;
using System.IO;
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.FileFormats.Svg;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class SvgImageTester
    {
        public static void Run()
        {
            // ExStart:SvgImageTester
            string dataDir = RunExamples.GetDataDir_MetaFiles();
            // ExEnd:SvgImageTester
        }

        #region Constants
        // Please update the path in the constant SourceFolder.
        private const string ImageFolderName = "Images";
        private const string OutFolderName = "Out";
        private const string SourceFolder = @"D:\ImageTests";

        private static readonly string OutFolder = Path.Combine(SourceFolder, OutFolderName);
        private static readonly string ImageFolder = Path.Combine(OutFolder, ImageFolderName);
        #endregion

        #region Methods

        public void SaveWithEmbeddedImages()
        {
            string[] files = new string[1] { "auto.svg" };
            for (int i = 0; i < files.Length; i++)
            {
                this.Save(true, files[i], null);
            }
        }

        public void SaveWithExportImages()
        {
            string[] files = new string[1] { "auto.svg" };
            string[][] expectedImages = new string[1][]
            {
                new string[16]
                {
                    "svg_img1.png", "svg_img10.png", "svg_img11.png", "svg_img12.png",
                    "svg_img13.png", "svg_img14.png", "svg_img15.png", "svg_img16.png",
                    "svg_img2.png", "svg_img3.png", "svg_img4.png", "svg_img5.png",
                    "svg_img6.png", "svg_img7.png", "svg_img8.png", "svg_img9.png"
                },
            };

            for (int i = 0; i < files.Length; i++)
            {
                this.Save(false, files[i], expectedImages[i]);
            }
        }

        private void Save(bool useEmbedded, string fileName, string[] expectedImages)
        {
            if (!Directory.Exists(OutFolder))
            {
                Directory.CreateDirectory(OutFolder);
            }

            string storeType = useEmbedded ? "Embedded" : "Stream";
            string inputFile = Path.Combine(SourceFolder, fileName);
            string outFileName = Path.GetFileNameWithoutExtension(fileName) + "_" + storeType + ".svg";
            string outputFile = Path.Combine(OutFolder, outFileName);
            string imageFolder = string.Empty;

            using (Image image = Image.Load(inputFile))
            {
                EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions
                {
                    BackgroundColor = Color.White,
                    PageWidth = image.Width,
                    PageHeight = image.Height
                };

                string testingFileName = Path.GetFileNameWithoutExtension(inputFile);
                imageFolder = Path.Combine(ImageFolder, testingFileName);
                image.Save(outputFile, new SvgOptions
                {
                    VectorRasterizationOptions = emfRasterizationOptions,
                    Callback = new SvgCallbackImageTest(useEmbedded, imageFolder)
                    {
                        Link = ImageFolderName + "/" + testingFileName
                    }
                });
            }

            if (!useEmbedded)
            {
                string[] files = Directory.GetFiles(imageFolder);
                if (files.Length != expectedImages.Length)
                {
                    throw new Exception(string.Format("Expected number of image files = {0}, actual count = {1}", expectedImages.Length, files.Length));
                }

                for (int i = 0; i < files.Length; i++)
                {
                    string file = Path.GetFileName(files[i]);
                    if (string.IsNullOrEmpty(file))
                    {
                        throw new Exception(string.Format("Expected file name: '{0}', but current file name is empty", expectedImages[i]));
                    }

                    if (!file.Equals(expectedImages[i], StringComparison.OrdinalIgnoreCase))
                    {
                        throw new Exception(string.Format("Expected file name: '{0}', actual: '{1}'", expectedImages[i], file));
                    }
                }
            }
        }

        #endregion

        private class SvgCallbackImageTest : FileFormats.Svg.SvgResourceKeeperCallback
        {
            #region Fields

            /// <summary>
            /// The output folder where resources are saved.
            /// </summary>
            private readonly string outFolder;

            /// <summary>
            /// Indicates whether to embed the image in the SVG.
            /// </summary>
            private readonly bool useEmbeddedImage;

            #endregion

            #region Constructors

            /// <summary>
            /// Initializes a new instance of the <see cref="SvgCallbackImageTest"/> class.
            /// </summary>
            /// <param name="useEmbeddedImage">If set to <c>true</c>, the image will be embedded.</param>
            /// <param name="outFolder">The output folder.</param>
            public SvgCallbackImageTest(bool useEmbeddedImage, string outFolder)
            {
                this.useEmbeddedImage = useEmbeddedImage;
                this.outFolder = outFolder;
            }

            #endregion

            #region Properties

            /// <summary>
            /// Gets or sets the relative link used when returning a non‑embedded resource path.
            /// </summary>
            public string Link { get; set; }

            #endregion

            #region Methods

            /// <summary>
            /// Called when an image resource is ready.
            /// </summary>
            /// <param name="imageData">The image data.</param>
            /// <param name="imageType">The type of the image.</param>
            /// <param name="suggestedFileName">The suggested file name.</param>
            /// <param name="useEmbeddedImage">If set to <c>true</c>, the image will be embedded.</param>
            /// <returns>The path to the saved resource, relative to the target SVG document.</returns>
            public override string OnImageResourceReady(byte[] imageData, SvgImageType imageType, string suggestedFileName, ref bool useEmbeddedImage)
            {
                useEmbeddedImage = this.useEmbeddedImage;

                if (useEmbeddedImage)
                {
                    return suggestedFileName;
                }

                string resourceFolder = this.outFolder;
                if (!Directory.Exists(resourceFolder))
                {
                    Directory.CreateDirectory(resourceFolder);
                }

                string fileName = Path.Combine(resourceFolder, Path.GetFileName(suggestedFileName));

                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    fs.Write(imageData, 0, imageData.Length);
                }

                return "./" + this.Link + "/" + suggestedFileName;
            }

            #endregion
        }
    }
}