using System.Web.Http;
using System.Threading.Tasks;
using Aspose.Imaging;
using Aspose.Imaging.Brushes;
using System;
using System.Diagnostics;

namespace Aspose.Imaging.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeImagingWatermark class to add or remove watermark 
	///</Summary>
	public class AsposeImagingWatermark : AsposeImagingBase
	{
		private Response ProcessTask(string fileName, string folderName, string outFileExtension, bool createZip,  bool checkNumberofPages, ActionDelegate action)
		{
			Aspose.Imaging.Live.Demos.UI.Models.License.SetAsposeImagingLicense();
			return  Process(this.GetType().Name, fileName, folderName, outFileExtension, createZip, checkNumberofPages,  (new StackTrace()).GetFrame(5).GetMethod().Name, action);
		}
		///<Summary>
		/// AddingDiagonalWatermark method to add diagonal watermark
		///</Summary>
	
		public Response AddingDiagonalWatermark(string fileName, string folderName, string watermarkText, string userEmail, string outputType, string watermarkColor)
		{
			outputType = outputType.ToLower().Trim();
			return  ProcessTask(fileName, folderName, "." + outputType, false,  false, delegate (string inFilePath, string outPath, string zipOutFolder)
			{
				// Load an existing JPG image
				using (Image image = Image.Load(inFilePath))
				{
					// Declare a String object with Watermark Text
					string theString = watermarkText;

					// Create and initialize an instance of Graphics class and Initialize an object of SizeF to store image Size
					Graphics graphics = new Graphics(image);
					SizeF sz = graphics.Image.Size;

					// Creates an instance of Font, initialize it with Font Face, Size and Style
					Font font = new Font("Times New Roman", 20, FontStyle.Bold);

					// Create an instance of SolidBrush and set its various properties
					SolidBrush brush = new SolidBrush();
					brush.Color = GetColor(watermarkColor);
					brush.Opacity = 0;

					// Initialize an object of StringFormat class and set its various properties
					StringFormat format = new StringFormat();
					format.Alignment = StringAlignment.Center;
					format.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;

					// Create an object of Matrix class for transformation
					Matrix matrix = new Matrix();

					// First a translation then a rotation                
					matrix.Translate(sz.Width / 2, sz.Height / 2);
					matrix.Rotate(-45.0f);

					// Set the Transformation through Matrix
					graphics.Transform = matrix;

					// Draw the string on Image Save output to disk
					graphics.DrawString(theString, font, brush, 0, 0, format);
					Aspose.Imaging.ImageOptionsBase imageOptionsBase = GetSaveFormat(outputType);
					if (imageOptionsBase == null)
					{

						image.Save(outPath);
					}
					else
					{
						image.Save(outPath, imageOptionsBase);
					}
				}
			});
		}
		private Color GetColor(string watermarkColor)
		{
			Color color;
			if (watermarkColor != "")
			{
				if (!watermarkColor.StartsWith("#"))
				{
					watermarkColor = "#" + watermarkColor;
				}
				System.Drawing.Color sColor = System.Drawing.ColorTranslator.FromHtml(watermarkColor);
				color = Color.FromArgb(sColor.A, sColor.R, sColor.G, sColor.B);
			}
			else
			{
				color = Color.FromArgb(50, 128, 128, 128);
			}
			return color;
		}
		///<Summary>
		/// AddWatermark method to add  watermark
		///</Summary>
		
		public Response AddWatermark(string fileName, string folderName, string watermarkText,  string outputType, string watermarkColor)
		{
			outputType = outputType.ToLower().Trim();
			return  ProcessTask(fileName, folderName, "." + outputType, false,  false, delegate (string inFilePath, string outPath, string zipOutFolder)
			{
				// Load a PSD file as an image and cast it into PsdImage
				using (Image image = Image.Load(inFilePath))
				{
					// Create graphics object to perform draw operations.
					Graphics graphics = new Graphics(image);

					// Create font to draw watermark with.
					Font font = new Font("Arial", 20.0f);

					// Create a solid brush with color alpha set near to 0 to use watermarking effect.
					using (SolidBrush brush = new SolidBrush(GetColor(watermarkColor)))
					{
						// Specify string alignment to put watermark at the image center.
						StringFormat sf = new StringFormat();
						sf.Alignment = StringAlignment.Center;
						sf.LineAlignment = StringAlignment.Center;

						// Draw watermark using font, partly-transparent brush and rotation matrix at the image center.
						graphics.DrawString(watermarkText, font, brush, new RectangleF(0, 0, image.Width, image.Height), sf);
					}
					Aspose.Imaging.ImageOptionsBase imageOptionsBase = GetSaveFormat(outputType);
					// Export the image into specified file format.
					if (imageOptionsBase == null)
					{

						image.Save(outPath);
					}
					else
					{
						image.Save(outPath, imageOptionsBase);
					}
				}

			});
		}

		private static ImageOptionsBase GetSaveFormat(string outputType)
		{
			switch (outputType)
			{
				case "bmp":
					return new Aspose.Imaging.ImageOptions.BmpOptions();
				case "gif":
					return new Aspose.Imaging.ImageOptions.GifOptions();
				case "jpeg":
					return new Aspose.Imaging.ImageOptions.JpegOptions();
				case "pdf":
					return new Aspose.Imaging.ImageOptions.PdfOptions();
				case "png":
					return new Aspose.Imaging.ImageOptions.PngOptions();
				case "psd":
					return new Aspose.Imaging.ImageOptions.PsdOptions();
				case "tiff":
					return new Aspose.Imaging.ImageOptions.TiffOptions(Imaging.FileFormats.Tiff.Enums.TiffExpectedFormat.Default);
				case "emf":
					return new Aspose.Imaging.ImageOptions.EmfOptions();

			}
			return null;
		}
	}
}
