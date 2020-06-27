# Aspose.Imaging for .NET

[Aspose.Imaging for .NET](https://products.aspose.com/imaging/net) is a library offering advanced image processing features. Developers can create, edit or convert images in their own application. Also Aspose. Imaging library supports drawing and work with graphic primitives. Image export and conversion (including uniform multi-page image processing) is the one of API core features along with image transformations (resize, crop, flip&rotate, binarization, grayscale, adjust), advanced image manipulation features (filtering, dithering, masking, deskewing) and memory optimization strategies.

This repository contains [Demos](Demos), [Examples](Examples), [Plugins](https://docs.aspose.com/display/imagingnet/Plugins) and [Showcase projects](https://docs.aspose.com/display/imagingnet/Showcases) for [Aspose.Imaging for .NET](https://products.aspose.com/imaging/net) to help you learn and write your own applications.

<p align="center">
  <a title="Download ZIP" href="https://github.com/aspose-imaging/Aspose.Imaging-for-.NET/archive/master.zip">
     <img src="http://i.imgur.com/hwNhrGZ.png" />
  </a>
</p>

This repository contains [Demos](Demos), [Examples](Examples), [Plugins](https://docs.aspose.com/display/imagingnet/Plugins) and Showcase projects for [Aspose.Imaging for .NET](https://products.aspose.com/imaging/net) to help you learn and write your own applications.

Directory | Description
--------- | -----------
[Demos](Demos)  | Aspose.Imaging for .NET Live Demos Source Code
[Examples](Examples)  | A collection of .NET examples that help you learn the product features
[Plugins](Plugins)  | Plugins that will demonstrate one or more features of Aspose.Imaging for .NET


# .NET API for Image Processing

It is a [standalone Imaging API](https://products.aspose.com/imaging/net) consists of C# routines that enable your .NET applications to draw as well as perform basic to advanced level processing of raster & vector images.

Aspose.Imaging for .NET offers robust image compression and high processing speed through native byte access and a range of efficient algorithms. It not only manipulate, export and convert images but also lets you dynamically draw objects using pixel manipulation and Graphics Path.

## Imaging API Features

- [Draw raster images with graphics](https://docs.aspose.com/display/imagingnet/Drawing+Images+using+Graphics).
- [Draw vector images](https://docs.aspose.com/display/imagingnet/Drawing+Vector+Images).
- [Converting images to various formats](https://docs.aspose.com/display/imagingnet/Converting+Images).
- [Apply masking](https://docs.aspose.com/display/imagingnet/Applying+Masking+to+Images) as well as [Median & Wiener](https://docs.aspose.com/display/imagingnet/Applying+Median+and+Wiener+Filters) filters.
- [Crop, rotate & resize images via API](https://docs.aspose.com/display/imagingnet/Crop%2C+Rotate+and+Resize+Images).
- [De-skew & transform images](https://docs.aspose.com/display/imagingnet/Deskew+image).
- [Set image properties](https://docs.aspose.com/display/imagingnet/Setting+Properties+on+Images).
- [Working with multipage image formats](https://docs.aspose.com/display/imagingnet/Working+with+multipage+image+formats).

## Compact Framework Off Notice

Please note, since 20.6 release of Aspose.Imaging support of .NET Compact Framework has been removed.

For the detailed notes, please visit [Aspose.Imaging for .NET 20.6 - Release notes](https://docs.aspose.com/display/imagingnet/Aspose.Imaging+for+.NET+20.6+-+Release+notes).

## Load & Save Image Formats

**Raster Formats:** JPEG2000, JPEG, BMP, TIFF, GIF, PNG, DICOM
**Metafiles:** EMF, WMF
**Compressed metafiles:** EMZ, WMZ
**Other:** WebP, Svg, Svgz (compressed Svg)
**Animation:** Apng

## Save Image formats
PDF
**Photoshop:** PSD
Html5 Canvas

## Load Image Formats

**Various:**     DjVu, DNG, ODG, EPS(raster preview only), CMX, CDR, DIB, OTG, FODG


## Platform Independence

Aspose.Imaging for .NET can be used to develop applications on Windows Desktop (x86, x64), Windows Server (x86, x64), Windows Azure, as well as Linux x64. The supported platforms include .NET Framework version 2.0 or higher, and .NET Compact Framework 3.5.

## Getting Started with Aspose.Imaging for .NET

Are you ready to give Aspose.Imaging for .NET a try? Simply execute `Install-Package Aspose.Imaging` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.Imaging for .NET and want to upgrade the version, please execute `Update-Package Aspose.Imaging` to get the latest version.

## Resize a JPG Image via C# Code

Execute below code snippet to see how Aspose.Imaging performs in your environment or check the [GitHub Repository](https://github.com/aspose-imaging/Aspose.Imaging-for-.NET) for other common usage scenarios. 

```csharp
using (Image image = Image.Load(dir + "template.jpg"))
{
    image.Resize(300, 300);
    image.Save(dir + "output.jpg");
}
```

## Create png image, manipulate it and save - C#

Using Aspose.Imaging for .NET you can easily create images with specified parameters, manipulate them and save.

```csharp
// Image width and height
int width = 500;
int height = 300;

// Where created image to store
string path = @"C:/createdImage.png";
// Create options
PngOptions options = new PngOptions() { Source = new FileCreateSource(path, false) };
using (PngImage image = (PngImage)Image.Create(options, width, height))
{          
     // Create and initialize an instance of Graphics class 
     // and Clear Graphics surface
     Graphics graphic = new Graphics(image);
     graphic.Clear(Color.Green);
     // Draw line on image
     graphic.DrawLine(new Pen(Color.Blue), 9, 9, 90, 90);        

     // Resize image
     int newWidth = 400;
     image.ResizeWidthProportionally(newWidth, ResizeType.LanczosResample);  

     // Crop the image to specified area
    Aspose.Imaging.Rectangle area = new Aspose.Imaging.Rectangle(10,10,200,200);    
    image.Crop(area);
   
    image.Save();
}
```

[Product Page](https://products.aspose.com/imaging/net) | [Docs](https://docs.aspose.com/display/imagingnet/Home) | [Demos](https://products.aspose.app/imaging/family) | [API Reference](https://apireference.aspose.com/imaging/net) | [Examples](https://github.com/aspose-imaging/Aspose.Imaging-for-.NET) | [Blog](https://blog.aspose.com/category/imaging/) | [Free Support](https://forum.aspose.com/c/imaging) | [Temporary License](https://purchase.aspose.com/temporary-license)
