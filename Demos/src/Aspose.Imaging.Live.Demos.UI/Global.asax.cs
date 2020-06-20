using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Aspose.Imaging.Live.Demos.UI.Config;


namespace Aspose.Imaging.Live.Demos.UI
{
	public class Global : HttpApplication
	{
		
		protected void Application_Error(object sender, EventArgs e)
		{			
			
		}

		void Application_Start(object sender, EventArgs e)
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			RouteConfig.RegisterRoutes(RouteTable.Routes);			
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			RegisterCustomRoutes(RouteTable.Routes);
		}
		void Session_Start(object sender, EventArgs e)
		{
			//Check URL to set language resource file
			string _language = "EN";
			
			SetResourceFile(_language);
		}

		private void SetResourceFile(string strLanguage)
		{
			if (Session["AsposeCellsResources"] == null)
				Session["AsposeCellsResources"] = new GlobalAppHelper(HttpContext.Current, Application, Configuration.ResourceFileSessionName, strLanguage);
		}
		
			void RegisterCustomRoutes(RouteCollection routes)
		{
			routes.RouteExistingFiles = true;
			routes.Ignore("{resource}.axd/{*pathInfo}");
					

			routes.MapRoute(
				name: "Default",
				url: "Default",
				defaults: new { controller = "Home", action = "Default" }
			);
			
			routes.MapRoute(
				"AsposeImagingConversionRoute",
				"{product}/Conversion",
				 new { controller = "Conversion", action = "Conversion" }
			);
			
			routes.MapRoute(
				"AsposeImagingWatermarkRoute",
				"{product}/watermark",
				 new { controller = "Watermark", action = "Watermark" }
			);
			
			
			
			routes.MapRoute(
				"DownloadFileRoute",
				"common/download",
				new { controller = "Common", action = "DownloadFile" }				
				
			);
			routes.MapRoute(
				"UploadFileRoute",
				"common/uploadfile",
				new { controller = "Common", action = "UploadFile" }

			);

			routes.MapPageRoute(
				"AsposeNewAppReverseSearchRoute",
				"imaging/reverse/{SearchId}",
				"~/ReverseImageSearchApp/ReverseSearchStart.aspx"
			);

			routes.MapPageRoute(
				"AsposeAppReverseSearchRoute",
				"imaging/reverse",
				"~/ReverseImageSearchApp/ReverseSearchStart.aspx", false,
				new RouteValueDictionary { { "SearchId", "new" } }
			);

			routes.MapPageRoute(
				"AsposeAppReverseSearchResultsRoute",
				"imaging/reverse/{SearchId}/results",
				"~/ReverseImageSearchApp/ReverseSearchResults.aspx"
			);
		}

		private void MapProductToolPageRoute(RouteCollection routes, string routeName, string routeUrl, string physicalFile, string productRegex)
		{
			routes.MapPageRoute(routeName, routeUrl, physicalFile, false, null, new RouteValueDictionary { { "Product", productRegex } });
		}
	}
}
