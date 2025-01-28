

using System.Text.Json;

namespace Bank_System
{
    internal class Parser
    {
        public static List<T> parseToObject<T>(string persons)
        {
            List<T> result = new List<T>();
            try
            {
                result = JsonSerializer.Deserialize<List<T>>(persons);

            }
            catch 
            {
            }
            
            return result;
        }

        public static string parseToJson<T>(List<T> persons)
        {
            string json = JsonSerializer.Serialize(persons);
            return json;
        }
    }
}
