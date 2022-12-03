using Microsoft.Extensions.Logging;
using System.Text.Json;
using WebAppPrototype.Models;

namespace WebAppPrototype.Helpers
{
    public class JsonFileWriter
    {
        public static void WritetoJsonBookings(List<Booking> bookings, string JsonFileName)
        {
            using (FileStream outputStream = File.Create(JsonFileName))
            {
                var writer = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Booking[]>(writer, bookings.ToArray());
            }
        }
    }
}
