![Nuget](https://img.shields.io/nuget/v/Aspose.Imaging) ![Nuget](https://img.shields.io/nuget/dt/Aspose.Imaging) ![GitHub](https://img.shields.io/github/license/aspose-imaging/Aspose.Imaging-for-.NET)

# .NET API for Image Processing

[Aspose.Imaging for .NET](https://products.aspose.com/imaging/net) is a library offering advanced image processing features. Developers can create, edit or convert images in their own application. Also Aspose. Imaging library supports drawing and work with graphic primitives. Image export and conversion (including uniform multi-page image processing) is the one of API core features along with image transformations (resize, crop, flip&rotate, binarization, grayscale, adjust), advanced image manipulation features (filtering, dithering, masking, deskewing) and memory optimization strategies.

<p align="center"> 
  <a title="Download ZIP" href="https://github.com/aspose-imaging/Aspose.Imaging-for-.NET/archive/master.zip">
     <img src="http://i.imgur.com/hwNhrGZ.png" />
  </a>
</p>

Directory | Description
--------- | -----------
[Demos](Demos)  | Source code for the live demos hosted at https://products.aspose.app/imaging/family.
[Examples](Examples)  | A collection of .NET examples that help you learn the product features.
[Plugins](Plugins)  | Plugins related to Aspose.Imaging for .NET product.

## Imaging Features

- [Draw raster images with graphics](https://docs.aspose.com/imaging/net/drawing-images-using-graphics/).
- [Draw vector images](https://docs.aspose.com/imaging/net/drawing-vector-images/).
- [Convert images to various formats](https://docs.aspose.com/imaging/net/converting-images/).
- [Apply masking](https://docs.aspose.com/imaging/net/applying-masking-to-images/) as well as [Median & Wiener](https://docs.aspose.com/imaging/net/applying-median-and-wiener-filters/) filters.
- [Crop, rotate & resize images via API](https://docs.aspose.com/imaging/net/crop-rotate-and-resize-images/).
- [De-skew & transform images](https://docs.aspose.com/imaging/net/deskew-image/).
- [Set image properties](https://docs.aspose.com/imaging/net/setting-properties-on-images/).
- [Work with multipage image formats](https://docs.aspose.com/imaging/net/working-with-multipage-image-formats/).

## Load & Save Image Formats

**Raster Formats:** JPEG2000, JPEG, BMP, TIFF, GIF, PNG, DICOM\
**Metafiles:** EMF, WMF\
**Compressed metafiles:** EMZ, WMZ\
**Other:** WebP, Svg, Svgz (compressed Svg)\
**Animation:** Apng

## Save Images As
**Fixed-layout:** PDF\
**Photoshop:** PSD\
**Web:** Html5 Canvas

## Load Images

**Various:** DjVu, DNG, ODG, EPS(raster preview only), CMX, CDR, DIB, OTG, FODG


## Platform Independence

Aspose.Imaging for .NET can be used to develop applications on Windows Desktop (x86, x64), Windows Server (x86, x64), Windows Azure, as well as Linux x64. The supported platforms include .NET Framework version 2.0 or higher.

## Get Started with Aspose.Imaging for .NET

Are you ready to give Aspose.Imaging for .NET a try? Simply execute `Install-Package Aspose.Imaging` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.Imaging for .NET and want to upgrade the version, please execute `Update-Package Aspose.Imaging` to get the latest version.

## Resize a JPG Image

```csharp
using (Image image = Image.Load(dir + "template.jpg"))
{
    image.Resize(300, 300);
    image.Save(dir + "output.jpg");
}
```

## Create & Manipulate PNG via API

```csharp
// image width and height
int width = 500;
int height = 300;

// where created image to store
string path = @"createdImage.png";
// create options
PngOptions options = new PngOptions() { Source = new FileCreateSource(path, false) };
using (PngImage image = (PngImage)Image.Create(options, width, height))
{          
     // create and initialize an instance of Graphics class 
     // and Clear Graphics surface
     Graphics graphic = new Graphics(image);
     graphic.Clear(Color.Green);
     // draw line on image
     graphic.DrawLine(new Pen(Color.Blue), 9, 9, 90, 90);        

     // resize image
     int newWidth = 400;
     image.ResizeWidthProportionally(newWidth, ResizeType.LanczosResample);  

     // crop the image to specified area
    Aspose.Imaging.Rectangle area = new Aspose.Imaging.Rectangle(10,10,200,200);    
    image.Crop(area);
   
    image.Save();
}
```

[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/imaging/net) | [Docs](https://docs.aspose.com/imaging/net/) | [Demos](https://products.aspose.app/imaging/family) | [API Reference](https://apireference.aspose.com/imaging/net) | [Examples](https://github.com/aspose-imaging/Aspose.Imaging-for-.NET) | [Blog](https://blog.aspose.com/category/imaging/) | [Search](https://search.aspose.com/) | [Free Support](https://forum.aspose.com/c/imaging) | [Temporary License](https://purchase.aspose.com/temporary-license)

