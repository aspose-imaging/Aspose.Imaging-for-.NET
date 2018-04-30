using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.FileFormats.Eps;
using Aspose.Imaging.FileFormats.Eps.Consts;
using Aspose.Imaging.Examples.CSharp;

namespace CSharp.ModifyingAndConvertingImages
{
    public class SupportForEPSFormat
    {
        public static void Run()
        {
            //ExStart:SupportForEPSFormat
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            using (EpsImage epsImage = Image.Load(dataDir+"anyEpsFile.eps") as EpsImage)
            {
                // check if EPS image has any raster preview to proceed (for now only raster preview is supported)
                if (epsImage.HasRasterPreview)
                {
                    if (epsImage.PhotoshopThumbnail != null)
                    {
                        // process Photoshop thumbnail if it's present
                    }

                    if (epsImage.EpsType == EpsType.Interchange)
                    {
                        // Get EPS Interchange subformat instance
                        EpsInterchangeImage epsInterchangeImage = epsImage as EpsInterchangeImage;

                        if (epsInterchangeImage.RasterPreview != null)
                        {
                            // process black-and-white Interchange raster preview if it's present
                        }
                    }
                    else
                    {
                        // Get EPS Binary subformat instance
                        EpsBinaryImage epsBinaryImage = epsImage as EpsBinaryImage;

                        if (epsBinaryImage.TiffPreview != null)
                        {
                            // process TIFF preview if it's present
                        }

                        if (epsBinaryImage.WmfPreview != null)
                        {
                            // process WMF preview if it's present
                        }
                        }

                    // export EPS image to PNG (by default, best available quality preview is used for export)
                    epsImage.Save(dataDir+"anyEpsFile.png", new PngOptions());
                }
            }

            //ExEnd:SupportForEPSFormat

        }

    }
}