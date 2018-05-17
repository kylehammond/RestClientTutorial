using System;
using System.IO;
using System.Net;

namespace RestClientTutorial.Services
{
    internal class RestClient
    {
        public RestClient(string endPoint)
        {
            EndPoint = endPoint;
            HttpMethod = HttpMethod.GET;
        }

        private string EndPoint { get; }
        private HttpMethod HttpMethod { get; }

        public string MakeRequest()
        {
            string responseValue;
            var request = WebRequest.Create(EndPoint);
            request.Method = HttpMethod.ToString();

            using (var response = (HttpWebResponse) request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new ApplicationException("Error code: " + response.StatusCode);

                // process the response stream (could be json, xml, html, etc..)
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    responseValue = reader.ReadToEnd();
                }
            }

            return responseValue;
        }
    }
}