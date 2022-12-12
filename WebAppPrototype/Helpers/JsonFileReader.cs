using System.Text.Json;
using WebAppPrototype.Models;

namespace WebAppPrototype.Helpers {
    public class JsonFileReader {
        public static List<Booking> ReadJsonBookings(string jsonFileName) {
            using (var jsonFileReader = File.OpenText(jsonFileName)) {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Booking>>(indata);
            }
        }
        public static List<User> ReadJsonUsers(string jsonFileName) {
            using (var jsonFileReader = File.OpenText(jsonFileName)) {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<User>>(indata);
            }
        }
        public static List<Boat> ReadJsonBoats(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Boat>>(indata);
            }
        }

    }
}