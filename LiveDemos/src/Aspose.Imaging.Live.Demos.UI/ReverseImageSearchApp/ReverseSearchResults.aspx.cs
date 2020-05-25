//-----------------------------------------------------------------------------------------------------------
// <copyright file="ReverseSearchResults.aspx.cs" company="Aspose Pty Ltd." author="A. Ermakov" date="12/5/2018 4:31:15 PM">
//     Copyright (c) 2001-2018 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

namespace Aspose.Imaging.Live.Demos.UI.ReverseImageSearchApp
{
    using System;
	using System.Collections.Generic;
    using System.Web.UI;
    using System.Web.UI.WebControls;
	using Aspose.Imaging.Live.Demos.UI.Models;
	using Config;

    public partial class ReverseSearchResults : BasePage
    {
		public const string AppFeedbackEmail = "Alexander.Ermakov@aspose.com";

		public List<AnotherApp> OtherApps { get; private set; } = new List<AnotherApp>
		{
			new AnotherApp("Imaging", "Conversion"),
			new AnotherApp("Imaging", "Watermark"),
			new AnotherApp("Imaging", "Reverse"),
		};

		protected void Page_Load(object sender, EventArgs e)
        {
			Product = "Imaging";

			this.hdnSearchId.Value = Page.RouteData.Values["SearchId"]?.ToString();

            if (!this.IsPostBack)
            {
                try
                {
                    var status = AsposeReverseSearchApiHelper.GetReverseSearchStatus(this.hdnSearchId.Value);
                    if (status != null)
                    {
                        ViewState["site"] = status.Site;
                        ViewState["searchId"] = status.Id;
                        this.hdnSearchStatus.Value = ((int)status.State).ToString();

                        this.IndexingPlaceHolder.Visible =
                            status.State == AsposeReverseSearchApiHelper.SearchState.Indexing;
                        this.SearchingPlaceHolder.Visible =
                            status.State == AsposeReverseSearchApiHelper.SearchState.Searching;
                        this.ResultsPlaceHolder.Visible =
                            status.State == AsposeReverseSearchApiHelper.SearchState.Ready;

                        if (status.State == AsposeReverseSearchApiHelper.SearchState.Ready)
                        {
                            this.ShowSearchResults(AsposeReverseSearchApiHelper.GetLastResuts(status.Id));
                        }
                    }
                }
                catch (Exception)
                {
                    this.Response.Redirect("~/errorpage");
                }

                this.btnNewSearch.Text = Resources["ReverseSearchNewImage"];

                // Set page settings based on from and top selection
                this.PageSettings();
            }
        }

        private void ShowSearchResults(AsposeReverseSearchApiHelper.ImagesSearchResult searchResult)
        {
            var resultStr = searchResult.Images?.Length == 1
                ? Resources["ReverseSearchResult"]
                : Resources["ReverseSearchResults"];

            this.hResultsCount.InnerText = (searchResult.Images?.Length ?? 0) +" " + resultStr;

            this.hSiteName.InnerText = string.Format(Resources["ReverseSearchOnSite"], searchResult.Site);

            this.hTotalImagesCount.InnerText = searchResult.TotalImagesCount > 0
                ? string.Format(Resources["ReverseSearchTotalImagesCount"], searchResult.TotalImagesCount)
                : string.Empty;

            if (searchResult.SearchImage != null)
            {
                this.imgSearchImage.ImageUrl = searchResult.SearchImage.Image;
            }

            this.ShowResult(searchResult);
        }

        private void ShowResult(AsposeReverseSearchApiHelper.ImagesSearchResult searchResult)
        {
            if (searchResult != null)
            {
                this.listview1.DataSource = searchResult.Images;
                this.listview1.DataBind();
            }
        }

        protected void ListView1_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            ContactsDataPager.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);

            ShowResult(AsposeReverseSearchApiHelper.GetLastResuts(this.hdnSearchId.Value));
        }        

        private void PageSettings()
        {
            var mySiteMaster = (SiteMaster)this.Master;
            mySiteMaster.Page.Title = this.Resources["ApplicationTitle"] + " | " +
                                      this.Resources["ReverseSearchStartPageTitle"];

            this.hAsposeProductTitle.InnerText = this.Resources["Aspose" + this.TitleCase("imaging")];
            this.hAsposeProductTitle.InnerText = this.hAsposeProductTitle.InnerText + " " + this.Resources["ReverseSearch4"];
        }

       

        protected void btnNewSearch_Click(object sender, EventArgs e)
        {
            Response.RedirectToRoute("AsposeNewAppReverseSearchRoute", new { SearchId = this.hdnSearchId.Value });
        }

        protected void OnUpdateSearchState(object sender, EventArgs e)
        {
            this.hSiteName.InnerText = DateTime.UtcNow.ToString();
        }
    }
}
