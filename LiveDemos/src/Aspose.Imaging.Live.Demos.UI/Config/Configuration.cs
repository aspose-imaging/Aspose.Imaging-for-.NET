using System;
using System.Data;
using System.Configuration;
using System.Web;

/// <summary>
/// Summary description for Configuration
/// </summary>
namespace Aspose.Imaging.Live.Demos.UI.Config
{
	public static class Configuration
	{		
		private static string _appName = ConfigurationManager.AppSettings["AppName"].ToString();
		private static string _asposeImagingLiveDemosPath = ConfigurationManager.AppSettings["AsposeImagingLiveDemosPath"].ToString();
		private static string _resourceFileSessionName = ConfigurationManager.AppSettings["ResourceFileSessionName"];
		private static string _asposeReverseSearchApiURL = ConfigurationManager.AppSettings["AsposeReverseSearchAPIBasePath"].ToString();
		private static string _productsAsposeImagingAssetURL = ConfigurationManager.AppSettings["ProductsAsposeImagingAssetURL"];
		private static string _fileDownloadLink = ConfigurationManager.AppSettings["FileDownloadLink"];
		

		public static string ResourceFileSessionName
		{
			get { return _resourceFileSessionName; }
		}
		/// <summary>
		/// Get Working Directory
		/// </summary>
		public static string WorkingDirectory
		{
			get {
				string sourceFilespath = HttpContext.Current.Server.MapPath("~/Assets/SourceFiles/");
				if ( ! System.IO.Directory.Exists(sourceFilespath))
				{
					System.IO.Directory.CreateDirectory(sourceFilespath);
				}

				return sourceFilespath;
			}
		}
		public static string AsposeReverseSearchApiURL
		{
			get { return _asposeReverseSearchApiURL; }
		}
		/// <summary>
		/// Get Working Directory
		/// </summary>
		public static string OutputDirectory
		{
			get
			{
				string OutputFilespath = HttpContext.Current.Server.MapPath("~/Assets/OutputFiles/");
				if (!System.IO.Directory.Exists(OutputFilespath))
				{
					System.IO.Directory.CreateDirectory(OutputFilespath);
				}

				return OutputFilespath;
			}
		}		
		public static string ProductsAsposeAppAssetsURL
		{
			get { return _productsAsposeImagingAssetURL; }
		}	
		
		public static string AppName
        {
            get { return _appName; }
        }
        public static string AsposeCellsLiveDemosPath
        {
            get { return _asposeImagingLiveDemosPath; }
        }
		public static string FileDownloadLink
		{
			get { return _fileDownloadLink; }
		}
		
		
	}
}
