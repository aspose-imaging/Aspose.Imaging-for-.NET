using System.IO;
using Aspose.Svg;
using ImageOptions;
using Imaging.FileFormats.Svg;


namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
  class SvgImageTester
{
      public static void Run()
      {
          //ExStart:SvgImageTester
          string dataDir = RunExamples.GetDataDir_MetaFiles();
      }
      #region Constants
      //Please Update path int constant SourceFolder.
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
    "svg_img1.png", "svg_img10.png", "svg_img11.png","svg_img12.png",
    "svg_img13.png", "svg_img14.png", "svg_img15.png", "svg_img16.png",
    "svg_img2.png", "svg_img3.png", "svg_img4.png", "svg_img5.png",
     "svg_img6.png","svg_img7.png", "svg_img8.png", "svg_img9.png"
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
EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();
emfRasterizationOptions.BackgroundColor = Color.White;
emfRasterizationOptions.PageWidth = image.Width;
emfRasterizationOptions.PageHeight = image.Height;
string testingFileName = Path.GetFileNameWithoutExtension(inputFile);
imageFolder = Path.Combine(ImageFolder, testingFileName);
image.Save(outputFile,
new SvgOptions
{
VectorRasterizationOptions = emfRasterizationOptions,
Callback =
new SvgCallbackImageTest(useEmbedded, imageFolder)
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
throw new Exception(string.Format("Expected count font files = {0}, Current count image files = {1}", expectedImages.Length, files.Length));
}
 
for (int i = 0; i < files.Length; i++)
{
string file = Path.GetFileName(files[i]);
if (string.IsNullOrEmpty(file))
{
throw new Exception(string.Format("Expected file name: '{0}', current is empty", expectedImages[i]));
}
 
if (file.ToLower() != expectedImages[i])
{
throw new Exception(string.Format("Expected file name: '{0}', current: '{1}'", expectedImages[i], file.ToLower()));
}
}
}
}
 
#endregion
 
       private class SvgCallbackImageTest : SvgResourceKeeperCallback
{
    #region Fields
 
/// <summary>
/// The out folder
/// </summary>
private readonly string outFolder;
 
/// <summary>
/// The use embedded font
/// </summary>
private readonly bool useEmbeddedImage;
 
#endregion
 
    #region Constructors
 
/// <summary>
/// Initializes a new instance of the <see cref="SvgTests.SvgCallbackFontTest" /> class.
/// </summary>
/// <param name="useEbeddedImage">if set to <c>true</c> [use ebedded image].</param>
/// <param name="outFolder">The out folder.</param>
public SvgCallbackImageTest(bool useEbeddedImage, string outFolder)
{
this.useEmbeddedImage = useEbeddedImage;
this.outFolder = outFolder;
}
 
#endregion
 
#region Properties
 
public string Link { get; set; }
 
#endregion
 
#region Methods
 
/// <summary>
/// Called when image resource ready.
/// </summary>
/// <param name="imageData">The resource data.</param>
/// <param name="imageType">Type of the image.</param>
/// <param name="suggestedFileName">Name of the suggested file.</param>
/// <param name="useEmbeddedImage">if set to <c>true</c> the embedded image must be used.</param>
/// <returns>
/// Returns path to saved resource. Path should be relative to target SVG document.
/// </returns>
public override string OnImageResourceReady(byte[] imageData, SvgImageType imageType, string suggestedFileName, ref bool useEmbeddedImage)
{
useEmbeddedImage = this.useEmbeddedImage;
 
if (useEmbeddedImage)
{
return suggestedFileName;
}
 
string fontFolder = this.outFolder;
if (!Directory.Exists(fontFolder))
{
Directory.CreateDirectory(fontFolder);
}
 
string fileName = fontFolder + @"\" + Path.GetFileName(suggestedFileName);
 
using (FileStream fs = new FileStream(fileName, FileMode.Create))
{
fs.Write(imageData, 0, imageData.Length);
}
 
return @"./" + this.Link + "/" + suggestedFileName;
}
 
 
#endregion
}
      }

  //ExEnd:SvgImageTester
   
      }
