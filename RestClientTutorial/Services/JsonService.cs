using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using Newtonsoft.Json;

namespace RestClientTutorial.Services
{
    public static class JsonService
    {
        public static dynamic GetDeserializedJson(string json)
        {
            try
            {
                var deserializedObject = JsonConvert.DeserializeObject<dynamic>(json);
                return deserializedObject;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
