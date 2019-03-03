using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageLoadOptions;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.PSD
{
    class SetFontsFolder
    {
        public static void Run()
        {
            //ExStart:SetFontsFolder
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            string sourceFIle = dataDir+"grinched-regular-font.psd";
            //Folder that contains fonts that we want to use for rendering 
            //(file GrinchedRegular.otf must be in this folder for proper work of example)
            Aspose.Imaging.FontSettings.SetFontsFolder(dataDir +"Fonts\\");
            Aspose.Imaging.FontSettings.UpdateFonts();
            using (PsdImage image = (PsdImage)Image.Load(sourceFIle, new PsdLoadOptions()))
            {
                image.Save(dataDir + "grinched-regular-font.png", new PngOptions());
            }
            //ExEnd:SetFontsFolder
        }
    }
}
