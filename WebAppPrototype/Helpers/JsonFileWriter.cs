using Microsoft.Extensions.Logging;
using System.Diagnostics.Metrics;
using System.Text.Json;
using WebAppPrototype.Models;

namespace WebAppPrototype.Helpers {
    public class JsonFileWriter {
        public static void WritetoJsonBookings(List<Booking> bookings, string jsonFileName) {
            using (FileStream outputStream = File.Create(jsonFileName)) {
                var writer = new Utf8JsonWriter(outputStream, new JsonWriterOptions {SkipValidation = false, Indented = true,});
                JsonSerializer.Serialize<Booking[]>(writer, bookings.ToArray());
            }
        }
        public static void WriteToJsonUsers(List<User> users, string jsonFileName) {           
            using (FileStream outputStream = File.Create(jsonFileName)) {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions {SkipValidation = false, Indented = true,});
                JsonSerializer.Serialize<User[]>(writter, users.ToArray());
            }
        }
        public static void WriteToJsonBoats(List<Boat> boats, string jsonFileName)
        {
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions { SkipValidation = false, Indented = true, });
                JsonSerializer.Serialize<Boat[]>(writter, boats.ToArray());
            }
        }
    }
}
