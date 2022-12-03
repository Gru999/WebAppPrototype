using Microsoft.Extensions.Logging;
using WebAppPrototype.Helpers;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;

namespace WebAppPrototype.Services
{
    public class JsonBookingRepository : IBookingRepository {
        string JsonFileName = @"\JsonData\JsonBookings.json";
        public void AddEvent(Booking bk)
        {
            List<Booking> @bookings = GetAllBookings().ToList();
            List<int> bookingIds = new List<int>();
            foreach (var bok in bookings)
            {
                bookingIds.Add(bok.BookingId);
            }
            if (bookingIds.Count != 0)
            {
                int start = bookingIds.Max();
                bk.BookingId = start + 1;
            }
            else
            {
                bk.BookingId = 1;
            }
            @bookings.Add(bk);
            JsonFileWriter.WritetoJsonBookings(@bookings, JsonFileName);
        }

        public void DeleteEvent(int bookingId)
        {
            List<Booking> bookings = GetAllBookings().ToList();
            Booking deleteBooking = GetBooking(bookingId);
            bookings.Remove(deleteBooking);
            JsonFileWriter.WritetoJsonBookings(bookings, JsonFileName);
        }

        public List<Booking> FilterBookings(string filter)
        {
            List<Booking> filterList = new List<Booking>();
            foreach (var bk in GetAllBookings())
            {
                if (bk.Name.Contains(filter) || bk.Description.Contains(filter))
                {
                    filterList.Add(bk);
                }
            }
            return filterList;
        }

        public List<Booking> GetAllBookingsByUser(string user)
        {
            List<Booking> userBookings = new List<Booking>();
            List<Booking> bookings = GetAllBookings();
            foreach (var bok in bookings)
            {
                //userid - snak med Julie om hvad hun kalder den
                if (bok.memberUser.Equals(user))
                {
                    userBookings.Add(bok);
                }
            }
            return userBookings;
        }

        public List<Booking> GetAllBookings()
        {
            return JsonFileReader.ReadJsonBookings(JsonFileName);
        }

        public Booking GetBooking(int bookingId)
        {
            List<Booking> bookings = GetAllBookings();
            foreach (var bk in bookings)
            {
                if (bk.BookingId == bookingId)
                {
                    return bk;
                }
            }
            return new Booking();
        }

        public void UpdateBooking(Booking bk)
        {
            List<Booking> bookings = GetAllBookings().ToList();
            if (@bk != null)
            {
                foreach (Booking b in bookings)
                {
                    if (b.BookingId == bk.BookingId)
                    {
                        b.BookingId = bk.BookingId;
                        b.Name = bk.Name;
                        b.Description = bk.Description;
                        b.Price = bk.Price;
                        b.DateTime = bk.DateTime;
                    }
                }
                JsonFileWriter.WritetoJsonBookings(bookings, JsonFileName);
            }
        }
    }
}
