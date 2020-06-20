//-----------------------------------------------------------------------------------------------------------
// <copyright file="ReverseSearchStart.aspx.cs" company="Aspose Pty Ltd." author="A. Ermakov" date="12/4/2018 10:15:12 AM">
//     Copyright (c) 2001-2018 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

namespace Aspose.Imaging.Live.Demos.UI.ReverseImageSearchApp
{
    using System;
	using System.Collections.Generic;
	using Aspose.Imaging.Live.Demos.UI.Models;
	using Aspose.Imaging.Live.Demos.UI.Config;

    public partial class ReverseSearchStart : BasePage
    {
		public const string AppFeedbackEmail = "Alexander.Ermakov@aspose.com";
		public List<AnotherApp> OtherApps { get; private set; } = new List<AnotherApp>
		{
			new AnotherApp("Imaging", "Conversion"),
			new AnotherApp("Imaging", "Watermark"),
			new AnotherApp("Imaging", "Reverse"),
		};

		private void Page_Load(object sender, EventArgs e)
        {
			Product = "Imaging";

            this.rfvvInputIdOrSite.ErrorMessage = this.Resources["ReverseSearchInputTextMessage"];

			if (!this.IsPostBack)
            {
                this.hdnSearchId.Value = Page.RouteData.Values["SearchId"]?.ToString();
                this.btnStart.Text = this.Resources["btnReverseSearchStart"];

                // Set page settings based on from and top selection
                this.PageSettings();

                this.liProductFeature3.InnerText = string.Format(this.Resources["ReverseSearchSupportedImages"],
                    this.hdnAllowedFileTypes.Value.ToUpper());
                this.txtInputIdOrSite.Attributes.Add("placeholder",
                    this.Resources["ReverseSearchUrlOrIdTextPlaceholder"]);

                this.rfvFile.ErrorMessage = this.Resources["SelectorDropFileMessage"];
            }
        }

        private void SetFileTypeAllowedExtensions()
        {
            var product = "imaging";
            var validationExpression = this.Resources["ReverseSearchValidationExpression"].Replace("|.eps", "");
            var validFileExtensions = this.GetValidFileExtensions(validationExpression);
            this.imgProductImage.Src = "~/img/aspose-" + product + "-app.png";
            this.ValidateFileType.ValidationExpression =
                @"(.*?)(" + validationExpression + "|" + validationExpression.ToUpper() + ")$";
            this.ValidateFileType.ErrorMessage = this.Resources["InvalidFileExtension"] + " " + validFileExtensions;
            this.aPoweredBy.InnerText = this.Resources["Aspose" + this.TitleCase(product)];
            this.aPoweredBy.HRef = "https://products.aspose.com/" + product.ToLower();
            this.hdnAllowedFileTypes.Value = validFileExtensions;
        }

       

        //private string GetValidFileExtensions(string validationExpression)
        //{
        //    string validFileExtensions = validationExpression.Replace(".", "").Replace("|", ", ").ToUpper();

        //    int index = validFileExtensions.LastIndexOf(",");
        //    if (index != -1)
        //    {
        //        string substr = validFileExtensions.Substring(index);
        //        string str = substr.Replace(",", " or");
        //        validFileExtensions = validFileExtensions.Replace(substr, str);
        //    }

        //    return validFileExtensions;
        //}

        private void PageSettings()
        {
            var mySiteMaster = (SiteMaster)this.Master;
            mySiteMaster.Page.Title = this.Resources["ApplicationTitle"] + " | " +
                                      this.Resources["ReverseSearchStartPageTitle"];

            this.SetFileTypeAllowedExtensions();

            this.hAsposeProductTitle.InnerText = this.Resources["Aspose" + this.TitleCase("imaging")];
            this.hAsposeProductTitle.InnerText =
                this.hAsposeProductTitle.InnerText + " " + this.Resources["ReverseSearch4"];

            if (this.hdnSearchId.Value == null)
            {
                this.Response.Redirect("~/errorpage");
            }
            else if (this.hdnSearchId.Value != "new")
            {
                this.dvInputIdOrSite.Visible = false;

                var status = AsposeReverseSearchApiHelper.GetReverseSearchStatus(this.hdnSearchId.Value);
                if (status == null)
                {
                    this.Response.Redirect("~/errorpage");
                }
                else if (status.State != AsposeReverseSearchApiHelper.SearchState.Ready)
                {
                    Response.RedirectToRoute("AsposeAppReverseSearchResultsRoute", new { SearchId = status.Id });
                }

                if (status != null)
                {
                    this.txtInputIdOrSite.InnerText = status.Id;
                }
            }
        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            Guid inputId;
            var isIdInput =  Guid.TryParse(txtInputIdOrSite.Value, out inputId);
            var isNew = this.hdnSearchId.Value == "new";
            this.rfvFile.Enabled = !(isNew && isIdInput);

            Page.Validate("uploadFile");

            if (Page.IsValid)
            {
                pMessage.Attributes.Remove("class");
                pMessage.InnerHtml = "";

                string error = null;
                try
                {
                    AsposeReverseSearchApiHelper.ImageSearchStatus status = null;
                    if (isIdInput)
                    {
                        status = AsposeReverseSearchApiHelper.GetReverseSearchStatus(this.txtInputIdOrSite.Value);
                        if (status == null)
                        {
                            error = $"Reverse image search with Id {this.txtInputIdOrSite.Value} not found";
                        }
                        else if (status.State == AsposeReverseSearchApiHelper.SearchState.Ready)
                        {
                            var searchResults = this.FileUpload1.PostedFile.InputStream.Length == 0
                                ? AsposeReverseSearchApiHelper.GetLastResuts(status.Id)
                                : AsposeReverseSearchApiHelper.StartSearchSimilarImages(status.Id, this.FileUpload1.PostedFile.InputStream);
                            this.Session["searchResults"] = searchResults;
                        }
                    }
                    else
                    {
                        string url;
                        if (AsposeReverseSearchApiHelper.TryGetUrl(this.txtInputIdOrSite.Value, out url,out error))
                        {
                            status =
                                AsposeReverseSearchApiHelper.CreateReverseSearch(url,
                                    this.FileUpload1.PostedFile.InputStream);
                            if (status == null)
                            {
                                error =
                                    $"Cannot create reverse image search for the site {this.txtInputIdOrSite.Value}";
                            }
                        }
                    }

                    if (status == null)
                    {
                        pMessage.Visible = true;
                        pMessage.InnerHtml = error;
                        pMessage.Attributes.Add("class", "alert alert-danger");
                    }
                    else
                    {
                        Response.RedirectToRoute("AsposeAppReverseSearchResultsRoute", new { SearchId = status.Id });
                    }
                }
                catch (Exception ex)
                {
                    pMessage.Visible = true;
                    pMessage.InnerHtml = "Error: " + ex.Message;
                    pMessage.Attributes.Add("class", "alert alert-danger");
                }
            }
        }
    }
}
