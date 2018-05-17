using System;
using System.IO;
using System.Net;

namespace RestClientTutorial
{
    internal class RestClient
    {
        public string EndPoint { get; set; }
        public HttpMethod HttpMethod { get; set; }

        public RestClient(string endPoint)
        {
            EndPoint = endPoint;
            HttpMethod = HttpMethod.GET;
        }

        public string MakeRequest()
        {
            string responseValue;
            var request = WebRequest.Create(EndPoint);
            request.Method = HttpMethod.ToString();

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new ApplicationException("Error code: " + response.StatusCode);

                // process the response stream (could be json, xml, html, etc..)
                using (var responseStream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(responseStream))
                    {
                        responseValue = reader.ReadToEnd();
                    }
                }
            }

            return responseValue;
        }
    }
}