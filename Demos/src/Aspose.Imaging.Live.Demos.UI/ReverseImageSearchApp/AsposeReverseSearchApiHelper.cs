//-----------------------------------------------------------------------------------------------------------
// <copyright file="AsposeReverseSearchApiHelper.cs" company="Aspose Pty Ltd." author="A. Ermakov" date="12/5/2018 10:09:55 AM">
//     Copyright (c) 2001-2018 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

namespace Aspose.Imaging.Live.Demos.UI.ReverseImageSearchApp
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using Aspose.Imaging.Live.Demos.UI.Config;

    public static class AsposeReverseSearchApiHelper
    {
        public static ImagesSearchResult GetLastResuts(string searchId)
        {
            return UnwrapException(() =>
            {
                var url = GetUrl("results", searchId);
                var status = ApiHelper.CallGet<ImagesSearchResult>(url);
                return status.Result;
            });
        }

        public static void RegisterEmailNotification(string searchId, string email)
        {
            try
            {
                var url = GetUrl("notification", searchId) + $"?email={email}";
                ApiHelper.CallPostWithResponse(url).Wait();
            }
            catch (AggregateException ex)
            {
                throw ex.InnerException;
            }
        }

        public static ImageSearchStatus CreateReverseSearch(string site, Stream fileStream)
        {
            return UnwrapException(() =>
            {
                var content = new StreamContent(fileStream);
                var url = GetUrl("create", null) + $"?siteUrl={site}";
                var status = ApiHelper.CallPost<ImageSearchStatus>(url, content);
                return status.Result;
            });
        }

        public static ImageSearchStatus GetReverseSearchStatus(string searchId)
        {
            return UnwrapException(() =>
            {
                var url = GetUrl(null, searchId);
                var status = ApiHelper.CallGet<ImageSearchStatus>(url);
                return status.Result;
            });
        }

        public static ImagesSearchResult StartSearchSimilarImages(string searchId, Stream fileStream)
        {
            return UnwrapException(() =>
            {
                var content = new StreamContent(fileStream);
                var url = GetUrl("find", searchId);
                var status = ApiHelper.CallPost<ImagesSearchResult>(url, content);
                return status.Result;
            });
        }

        public static bool TryGetUrl(string value, out string validUrl, out string error)
        {
            if (IsUrl(value))
            {
                validUrl = value;
                error = CheckUrl(validUrl);
                return error.Length == 0;
            }

            validUrl = $"https://{value}";
            if (IsUrl(validUrl))
            {
                error = CheckUrl(validUrl);
                if (error.Length == 0)
                {
                    return true;
                }

                validUrl = $"http://{value}";
                error = CheckUrl(validUrl);
                return error.Length == 0;
            }

            validUrl = null;
            error = "Invalid URL";
            return false;
        }

        private static T UnwrapException<T>(Func<T> func)
        {
            try
            {
                return func();
            }
            catch (AggregateException ex)
            {
                throw ex.InnerException;
            }
        }

        private static string CheckUrl(string url)
        {
            return ApiHelper.CheckExist(url) 
                ? string.Empty 
                : $"URL '{url}' is not available";
        }

        private static bool IsUrl(string value)
        {
            const string strRegex = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
            var re = new Regex(strRegex);
            Uri uriResult;
            return re.IsMatch(value) && 
                   Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute) && 
                   Uri.TryCreate(value, UriKind.Absolute, out uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        private static string GetUrl(string action, string searchId)
        {
            var url = $"{Configuration.AsposeReverseSearchApiURL}reverseSearch/";
            if (searchId != null)
            {
                url += $"{searchId}";
            }

            if (action != null)
            {
                url += $"/{action}";
            }

            return url;
        }

        public class ImageSearchStatus
        {
            public string Id { get; set; }

            public SearchState State { get; set; }

            public string Site { get; set; }

            public Progress Progress { get; set; }
        }

        public class Progress
        {
            public TimeSpan Duration { get; set; }

            public int ProcessedImagesCount { get; set; }

            public int TotalImagesCount { get; set; }
        }

        public enum SearchState
        {
            Indexing,
            Searching,
            Ready
        }

        public class ImagesSearchResult
        {
            public string Site { get; set; }

            public int StartIndex { get; set; }

            public int TotalImagesCount { get; set; }

            public ImageInfo SearchImage { get; set; }

            public ImageInfo[] Images { get; set; }
        }

        public class ImageInfo
        {
            private const int MaxNameLenght = 50;

            private string image;

            public string Url { get; set; }

            public byte[] Thumbs { get; set; }

            public string Image => this.image ?? (this.image= "data:image/jpg;base64," + Convert.ToBase64String(this.Thumbs));

            public string ImageName => GetShortName(Path.GetFileName(Url));

            private string GetShortName(string name)
            {
                return name.Length <= MaxNameLenght 
                    ? name 
                    : $"...{name.Substring(name.Length - MaxNameLenght, MaxNameLenght)}";
            }
        }
    }
}