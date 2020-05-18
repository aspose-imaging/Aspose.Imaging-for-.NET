using Aspose.Imaging.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Imaging.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Apps, On Premise &amp; Cloud Solution for Image Processing - aspose.app";
			ViewBag.MetaDescription = "Develop image processing and manipulation applications using On Premise or Cloud APIs, or simply use cross-platform apps to view, compare, inspect or convert images.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
