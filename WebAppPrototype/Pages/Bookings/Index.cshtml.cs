using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;
using WebAppPrototype.Services;

namespace WebAppPrototype.Pages.Bookings {
    public class IndexModel : PageModel {
        private IBookingRepository _repo;
        private LogInRepository _logInRepo;

        //might need to bindproperty
        public User User { get; set; }
        //public string FilterCriteria { get; set; }
        //to get GetAllBookingsByUser working add User property
        public List<Booking> Bookings { get; private set; }
        public IndexModel(IBookingRepository repo, LogInRepository logInRepo) {
            _repo = repo;
            _logInRepo = logInRepo;
        }
        public IActionResult OnGet() {
            if (_logInRepo.GetLoggedUser().Equals(null)) {
                return RedirectToPage("Users/Login");
            } else {
                User = _logInRepo.GetLoggedUser();
                Bookings = _repo.GetAllBookingsByUser(User);
                return Page();
            }
        }
        public void OnPost() {
            //if (FilterCriteria != null) {
            //    Bookings = _repo.FilterBookings(FilterCriteria);
            //} else {
            //    Bookings = _repo.GetAllBookings();
            //}
        }
    }
}
