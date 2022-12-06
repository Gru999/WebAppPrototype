using System.Text.Json;
using WebAppPrototype.Models;

namespace WebAppPrototype.Helpers
{
    public class JsonFileReader
    {
        public static List<Booking> ReadJsonBookings(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Booking>>(indata);
            }
        }
       
    }
}