using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Aspose.Imaging.Exif;
using Aspose.Imaging.FileFormats.Jpeg;
namespace CSharp.ModifyingAndConvertingImages
{
    class ConvertImageWithGrayscale
    {
 
   //ExStart:ConvertImageWithGrayscale
  string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
  using(var image = Image.Load(dataDir + "aspose-logo.jpg"))
  JpegCompressionColorMode[] colorTypes = new JpegCompressionColorMode[]
 {
   JpegCompressionColorMode.Grayscale,
   JpegCompressionColorMode.YCbCr,
   JpegCompressionColorMode.Rgb,
   JpegCompressionColorMode.Cmyk,
   JpegCompressionColorMode.Ycck,
 };
 
  string[] sourceFileNames = new string[]
 {
  "Rgb.jpg",
  "Rgb.jpg",
  "Rgb.jpg",
  "Rgb.jpg",
  "Rgb.jpg",
  };
 
  JpegOptions options = new JpegOptions();
  options.BitsPerChannel = 12;
 
  for (int i = 0; i < colorTypes.Length; ++i)
  {
  options.ColorType = colorTypes[i];
  string fileName = colorTypes[i] + " 12-bit.jpg";
  using (Image image = Image.Load(sourceFileNames[i]))
  {
  image.Save(fileName, options);
  }
  }
  IMAGINGNET-1851 Support tiff deflate images with alpha

  string inputFile = @"D:\Alpha.png";
  string outputFileTiff = @"D:\Alpha.tiff";
  string outputFilePng = @"D:\Alpha1.png";
 
 //Export png with alpha channel to tiff
  using (Image image = Image.Load(inputFile))
  {
 TiffOptions options = new TiffOptions(TiffExpectedFormat.TiffDeflateRgba);
  image.Save(outputFileTiff, options);
  }
 
 //Export tiff with alpha channel to png
  using (Image image = Image.Load(outputFileTiff))
 {
  Assert.AreEqual(((RasterImage)image).HasAlpha, true);
  image.Save(outputFilePng, new PngOptions() { ColorType = PngColorType.TruecolorWithAlpha });
    //ExEnd:ConvertImageWithGrayscale
    }
       
    }
}
