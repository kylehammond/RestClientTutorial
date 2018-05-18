using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using RestClientTutorial.Constants;

namespace RestClientTutorial.Services
{
    internal class RestService
    {
        public RestService(string endPoint, HttpMethod httpMethod, AuthenticationType authenticationType, AuthenticationTechnique authenticationTechnique, BasicCredentials basicCredentials)
        {
            EndPoint = endPoint;
            HttpMethod = httpMethod;
            AuthenticationType = authenticationType;
            AuthenticationTechnique = authenticationTechnique;
            BasicCredentials = basicCredentials;
        }

        private string EndPoint { get; }
        private HttpMethod HttpMethod { get; }
        private AuthenticationType AuthenticationType { get; }
        private AuthenticationTechnique AuthenticationTechnique { get; }
        private BasicCredentials BasicCredentials { get; }

        public string MakeRequest()
        {
            try
            {
                string responseValue;

                var request = WebRequest.Create(EndPoint);
                var authenticationHeader = Convert.ToBase64String(Encoding.ASCII.GetBytes(BasicCredentials.UserName + ":" + BasicCredentials.Password));

                request.Method = HttpMethod.ToString();
                request.Headers.Add("Authorization", AuthenticationType + " " + authenticationHeader);

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK) throw new ApplicationException("Error code: " + response.StatusCode);

                    // process the response stream (could be json, xml, html, etc..)
                    using (var reader = new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException()))
                    {
                        responseValue = reader.ReadToEnd();
                    }
                }

                return responseValue;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
    }