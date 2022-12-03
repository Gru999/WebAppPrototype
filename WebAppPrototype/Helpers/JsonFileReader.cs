using Microsoft.Extensions.Logging;
using System.Diagnostics.Metrics;
using System.Text.Json;
using WebAppPrototype.Models;

namespace WebAppPrototype.Helpers
{
    public class JsonFileReader
    {
        public static List<Booking> ReadJsonBookings(string JsonFileName)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Booking>>(indata);
            }
        }
       
    }
}
