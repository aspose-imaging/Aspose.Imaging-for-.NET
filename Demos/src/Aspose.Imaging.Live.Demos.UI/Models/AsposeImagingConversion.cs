using System.Threading.Tasks;
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using System.IO;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.Sources;
using System.Diagnostics;


namespace Aspose.Imaging.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeImagingConversion class to convert image to different format
	///</Summary>
	public class AsposeImagingConversion : AsposeImagingBase
	{        
		private Response ProcessTask(string fileName, string folderName, string outFileExtension, bool createZip,  bool checkNumberofPages, ActionDelegate action)
		{
			Aspose.Imaging.Live.Demos.UI.Models.License.SetAsposeImagingLicense();
			return  Process(this.GetType().Name, fileName, folderName, outFileExtension, createZip, checkNumberofPages,  (new StackTrace()).GetFrame(5).GetMethod().Name, action);
		}
		///<Summary>
		/// ConvertImageToPdf method to convert image to Pdf
		///</Summary>
		public Response ConvertImageToPdf(string fileName, string folderName, string outputType)
        {
            return  ProcessTask(fileName, folderName, ".pdf", false, false, delegate (string inFilePath, string outPath, string zipOutFolder)
            {                
                using (Image image = Image.Load(inFilePath))
                {                
                    image.Save(outPath, new Aspose.Imaging.ImageOptions.PdfOptions());                                        
                }                
            });
        }
		///<Summary>
		/// ConvertImageToTiff method to convert image to tiff
		///</Summary>
		public Response ConvertImageToTiff(string fileName, string folderName, string outputType)
        {           
            ImageOptionsBase optionsBase = new TiffOptions(Imaging.FileFormats.Tiff.Enums.TiffExpectedFormat.TiffJpegRgb);               

            return  ProcessTask(fileName, folderName, "." + outputType, false,  false, delegate (string inFilePath, string outPath, string zipOutFolder)
            {
                using (Image image = Image.Load(inFilePath))
                {
                    image.Save(outPath, optionsBase);
                }
            });                        
        }
		///<Summary>
		/// ConvertImageFormat method to convert image to different image formats
		///</Summary>
		public Response ConvertImageFormat(string fileName, string folderName, string outputType)
        {
			if (outputType.Equals("gif") || outputType.Equals("bmp") || outputType.Equals("jpg") || outputType.Equals("png")
				|| outputType.Equals("psd") || outputType.Equals("emf") || outputType.Equals("svg") || outputType.Equals("wmf"))
			{
				ImageOptionsBase optionsBase = new BmpOptions();

				if (outputType.Equals("jpg"))
				{
					optionsBase = new JpegOptions();
				}
				else if (outputType.Equals("png"))
				{
					optionsBase = new PngOptions();
				}
				else if (outputType.Equals("gif"))
				{
					optionsBase = new GifOptions();
				}
				else if (outputType.Equals("psd"))
				{
					optionsBase = new PsdOptions();
				}
				else if (outputType.Equals("emf"))
				{
					optionsBase = new EmfOptions();
				}
				else if (outputType.Equals("svg"))
				{
					optionsBase = new SvgOptions();
				}
				else if (outputType.Equals("wmf"))
				{
					optionsBase = new WmfOptions();
				}
				return  ProcessTask(fileName, folderName, "." + outputType, true,  true, delegate (string inFilePath, string outPath, string zipOutFolder)
				{
					string fileExtension = Path.GetExtension(inFilePath).ToLower();
					if ((fileExtension == ".tif") || (fileExtension == ".tiff"))
					{
						string outfileName = Path.GetFileNameWithoutExtension(fileName) + "_{0}";
						using (TiffImage multiImage = (TiffImage)Image.Load(inFilePath))
						{
							if (multiImage.Frames.Length > 1)
							{
								int frameCounter = 0;
								// Iterate over the TiffFrames in TiffImage
								foreach (TiffFrame tiffFrame in multiImage.Frames)
								{
									multiImage.ActiveFrame = tiffFrame;
									// Load Pixels of TiffFrame into an array of Colors
									Color[] pixels = multiImage.LoadPixels(tiffFrame.Bounds);
									// Create an instance of JpegOptions

									// Set the Source of JpegOptions as FileCreateSource by specifying the location where output will be saved
									// Last boolean parameter denotes isTemporal
									outPath = zipOutFolder + "/" + outfileName;

									optionsBase.Source = new FileCreateSource(string.Format(outPath, frameCounter + 1) + "." + outputType, false);
									// Create a new RasterImage of Jpeg type
									using (var jpgImage = (RasterImage)Image.Create(optionsBase, tiffFrame.Width, tiffFrame.Height))
									{
										// Save the JpegImage with pixels from TiffFrame
										jpgImage.SavePixels(tiffFrame.Bounds, pixels);
										// Resize the Jpeg Image
										jpgImage.Resize(100, 100, ResizeType.NearestNeighbourResample);
										// Save the results on disk
										jpgImage.Save();
									}
									frameCounter++;
								}
							}
							else
							{								
								multiImage.Save(outPath, optionsBase);								
							}
						}
					}
					else

					{
						using (Image image =  Image.Load(inFilePath))
						{
							image.Save(outPath, optionsBase);
						}
					}
					
                });
            }

            return new Response
            {
                FileName = null,
                Status = "Output type not found",
                StatusCode = 500
            };
        }
		///<Summary>
		/// ConvertFile
		///</Summary>
		public Response ConvertFile(string fileName, string folderName, string outputType)
        {
            outputType = outputType.ToLower().Trim();

            if (outputType.StartsWith("pdf"))
            {
                return  ConvertImageToPdf(fileName, folderName, outputType);
            }
            else if (outputType.Equals("gif") || outputType.Equals("bmp") || outputType.Equals("jpg") || outputType.Equals("png")
                   || outputType.Equals("psd") || outputType.Equals("emf") || outputType.Equals("svg") || outputType.Equals("wmf"))
            {
                return  ConvertImageFormat(fileName, folderName, outputType);
            }
            else if (outputType.Equals("tiff"))
            {
                return  ConvertImageToTiff(fileName, folderName, outputType);
            }

            return  new Response
            {
                FileName = null,
                Status = "Output type not found",
                StatusCode = 500
            };
        }        
    }
}
