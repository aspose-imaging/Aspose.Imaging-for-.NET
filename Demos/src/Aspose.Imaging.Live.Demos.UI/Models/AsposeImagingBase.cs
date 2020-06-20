using System;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging.Live.Demos.UI.Models;
using Aspose.Imaging.Live.Demos.UI.Services;
using File = System.IO.File;
using Aspose.Imaging.Live.Demos.UI.Helpers;

namespace Aspose.Imaging.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeImagingBase class 
	///</Summary>

	public class AsposeImagingBase : ModelBase
	{
		
		/// <summary>
		/// Maximum number of files which can be uploaded for MVC Aspose.Words apps
		/// </summary>
		protected const int MaximumUploadFiles = 10;

    /// <summary>
    /// Original file format SaveAs option for multiple files uploading. By default, "-"
    /// </summary>
    protected const string SaveAsOriginalName = ".-";
    
    /// <summary>
    /// Response when uploaded files exceed the limits
    /// </summary>
    protected Response MaximumFileLimitsResponse = new Response()
    {
      Status = $"Number of files should be less {MaximumUploadFiles}",
      StatusCode = 500
    };
		/// <summary>
		/// Response when uploaded files exceed the limits
		/// </summary>
		protected Response PasswordProtectedResponse = new Response()
		{
			Status = "Some of your documents are password protected",
			StatusCode = 500
		};
		/// <summary>
		/// Response when uploaded files exceed the limits
		/// </summary>
		protected Response BadDocumentResponse = new Response()
		{
			Status = "Some of your documents are corrupted",
			StatusCode = 500
		};


		///<Summary>
		/// Aspose Cells Options Class
		///</Summary>
		protected class Options
		{
			///<Summary>
			/// AppName
			///</Summary>
			public string AppName;

			///<Summary>
			/// FolderName
			///</Summary>
			public string FolderName;

			///<Summary>
			/// FileName
			///</Summary>
			public string FileName;

			private string _outputType;

			/// <summary>
			/// By default, it is the extension of FileName
			/// </summary>
			public string OutputType
			{
				get => _outputType;
				set
				{
					if (!value.StartsWith("."))
						value = "." + value;
					_outputType = value;
				}
			}

			/// <summary>
			/// Check if OuputType is a picture extension
			/// </summary>
			public bool IsPicture
			{
				get
				{
					switch (_outputType.ToLower())
					{
						case ".bmp":
						case ".png":
						case ".jpg":
						case ".jpeg":
							return true;
						default:
							return false;
					}
				}
			}

			///<Summary>
			/// ResultFileName
			///</Summary>
			public string ResultFileName;

			///<Summary>
			/// MethodName
			///</Summary>
			public string MethodName;

			///<Summary>
			/// ModelName
			///</Summary>
			public string ModelName;

			///<Summary>
			/// CreateZip
			///</Summary>
			public bool CreateZip;

			///<Summary>
			/// CheckNumberOfPages
			///</Summary>
			public bool CheckNumberOfPages = false;

			///<Summary>
			/// DeleteSourceFolder
			///</Summary>
			public bool DeleteSourceFolder = false;

			///<Summary>
			/// CalculateZipFileName
			///</Summary>
			public bool CalculateZipFileName = true;

			/// <summary>
			/// Output zip filename (without '.zip'), if CreateZip property is true
			/// By default, FileName + AppName
			/// </summary>
			public string ZipFileName;

			/// <summary>
			/// AppSettings.WorkingDirectory + FolderName + "/" + FileName
			/// </summary>
			public string WorkingFileName
			{
				get
				{
					if (File.Exists(Config.Configuration.WorkingDirectory + FolderName + "/" + FileName))
						return Config.Configuration.WorkingDirectory + FolderName + "/" + FileName;
					return Config.Configuration.OutputDirectory + FolderName + "/" + FileName;
				}
			}
		}
		/// <summary>
		/// init Options
		/// </summary>
		protected Options Opts = new Options();
    
    /// <summary>
    /// UTF8WithoutBom
    /// </summary>
    protected static readonly Encoding UTF8WithoutBom = new UTF8Encoding(false);

	
		
		

	

		
	}
}
