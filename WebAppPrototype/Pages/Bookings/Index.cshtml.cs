using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;

namespace WebAppPrototype.Pages.Bookings {
    public class IndexModel : PageModel {
        private IBookingRepository _repo;
        public string FilterCriteria { get; set; }
        //to get GetAllBookingsByUser working add User property
        public List<Booking> Bookings { get; private set; }
        public IndexModel(IBookingRepository repo) {
            _repo = repo;
        }
        public void OnGet() {
            //should prob be GetAllBookingsByUser(User.Name)
            Bookings = _repo.GetAllBookings();
        }
        public void OnPost() {
            if (FilterCriteria != null) {
                Bookings = _repo.FilterBookings(FilterCriteria);
            } else {
                Bookings = _repo.GetAllBookings();
            }
        }
    }
}
