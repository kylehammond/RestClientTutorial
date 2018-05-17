using System;
using Newtonsoft.Json;

namespace RestClientTutorial.Services
{
    public static class JsonService
    {
        public static T GetDeserializedObject<T>(string json)
        {
            try
            {
                var deserializedObject = JsonConvert.DeserializeObject<T>(json);
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