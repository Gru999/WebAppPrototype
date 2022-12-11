using WebAppPrototype.Helpers;

namespace WebAppPrototype.Services
{
    public class JsonIdBookingRepository : IIdBookingRepository
    {
        string filePath = @"Data\JsonIdBookings.json";
        public void AddIdBooking(IdBooking idBooking)
        {
            List<IdBooking> bookings = GetAllIdBookings();
            List<int> bookingsIds = new List<int>();

            foreach (var b in bookings)
            {
                bookingsIds.Add(b.BookingId);
            }
            if (bookingsIds.Count != 0)
            {
                int start = bookingsIds.Max();
                IdBooking.BookingId = start + 1;
            }
            else
            {
                IdBooking.BookingId = 1;
            }
            bookings.Add(IdBooking);
            JsonFileWriter.WriteToJsonIdBooking(bookings, filePath);
        }

        public void DeleteHotelBooking(IdBooking idBooking)
        {
            throw new NotImplementedException();
        }

        public List<IdBooking> GetAllIdBookings()
        {
            return JsonFileReader.ReadJsonIdBookings(filePath);
        }

        public IdBooking GetIdBookingById(int id)
        {
            throw new NotImplementedException();
        }

        public List<IdBooking> GetIdBookingByUserId(int userId)
        {
            throw new NotImplementedException();
        }
        //need class for boats
    }
}
