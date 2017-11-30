using System;
using System.Diagnostics;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.FileFormats.Psd.Layers;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PSD
{
    class ColorReplacement
    {
        public static void Run()
        {
            //ExStart:ColorReplacement
            String path = "F:\\Aspose WPrk\\";
            string dataDir = RunExamples.GetDataDir_PSD();
            using (PsdImage image = (PsdImage)Image.Load(dataDir + "photooverlay_5_new_3.psd"))
            {

                PsdImage psdImage = image;
                var pngOptions = new PngOptions();
                foreach (var layer in psdImage.Layers)
                {
                    if (layer.GetType() == typeof(Aspose.Imaging.FileFormats.Psd.Layers.TextLayer))
                    {
                        if (layer.Name == "dealerwebsite")
                        {
                            ((Aspose.Imaging.FileFormats.Psd.Layers.TextLayer)layer).UpdateText("My new Text!", Color.Red);
                        }
                    }
                    else if (layer.Name == "Maincolor")
                    {
                        //layer.BackgroundColor = Color.Yellow;
                        //TODO: Change color of this layer  
                        int dd = 0;
                        layer.HasBackgroundColor = true;
                        layer.BackgroundColor = Color.Orange;


                       // layer.BackgroundColor = Color.Yellow;
                    }

                }
                psdImage.Save(dataDir+"asposeImage02.png", new Aspose.Imaging.ImageOptions.PngOptions());
            }

        }
            //ExEnd:ColorReplacement
        }
    }
