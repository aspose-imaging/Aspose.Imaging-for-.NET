//-----------------------------------------------------------------------------------------------------------
// <copyright file="ApiHelper.cs" company="Aspose Pty Ltd." author="A. Ermakov" date="2/1/2019 3:47:13 PM">
//     Copyright (c) 2001-2018 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

namespace Aspose.Imaging.Live.Demos.UI.ReverseImageSearchApp
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public static class ApiHelper
    {
        /// <summary>
        /// Calls GET method.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>Content as T.</returns>
        public static async Task<T> CallGet<T>(string url)
        {
            var response = await CallGetWithResponse(url);
            var result = await response.Content.ReadAsAsync<T>();
            return result;
        }

        /// <summary>
        /// Calls GET method.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>HTTP response.</returns>
        public static async Task<HttpResponseMessage> CallGetWithResponse(string url)
        {
            using (var client = CreateClient())
            {
                var response = await client.GetAsync(url);
                await EnsureSuccessStatusCode(response);
                return response;
            }
        }

        /// <summary>
        /// Calls POST method.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="content">Stream content.</param>
        /// <returns>Content as T.</returns>
        public static async Task<T> CallPost<T>(string url, HttpContent content = null)
        {
            var response = await CallPostWithResponse(url, content);
            var result = await response.Content.ReadAsAsync<T>();
            return result;
        }

        /// <summary>
        /// Calls POST method.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="content">Stream content.</param>
        /// <returns>HTTP response.</returns>
        public static async Task<HttpResponseMessage> CallPostWithResponse(string url, HttpContent content = null)
        {
            using (var client = CreateClient())
            {
                var response = await client.PostAsync(url, content);
                await EnsureSuccessStatusCode(response);
                return response;
            }
        }

        /// <summary>
        /// Checks the url is exist.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>Is exist.</returns>
        public static bool CheckExist(string url)
        {
            try
            {
                var request = WebRequest.CreateHttp(url);
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "HEAD";
                //Getting the Web Response.
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    //Returns TRUE if the Status code == 200
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch
            {
                //Any exception will returns false.
                return false;
            }
        }

        /// <summary>
        /// Creates the client.
        /// </summary>
        /// <returns>The http client.</returns>
        private static HttpClient CreateClient()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        private static async Task EnsureSuccessStatusCode(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var errorResult = await response.Content.ReadAsAsync<string>();
                if (!string.IsNullOrEmpty(errorResult))
                {
                    var error = JsonConvert.DeserializeObject<Error>(errorResult);
                    throw new HttpRequestException(error.Message);
                }

                response.EnsureSuccessStatusCode();
            }
        }
    }

    public class Error
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}