using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;
using WebAppPrototype.Services;

namespace WebAppPrototype.Pages.Bookings {
    public class CreateBookingModel : PageModel {
        private IBookingRepository _bookingRepo;
        private LogInRepository _loggedInUser;
        private IBoatRepository _boatRepo;
        private IUserRepository _userRepo;

        [BindProperty]
        public Booking Booking { get; set; }
        public User User { get; set; }
        public SelectList BoatName { get; set; }
        public CreateBookingModel(IBookingRepository bookingRepo, LogInRepository loggedInUser, IBoatRepository boatRepo) {
            _bookingRepo = bookingRepo;
            _loggedInUser = loggedInUser;
            List<Boat> Boats = _boatRepo.GetAllBoats();
            BoatName = new SelectList(Boats, "BoatId", "BoatName");
        }

        public IActionResult OnGet() {
            if (_loggedInUser.GetLoggedUser().Equals(null)) {
                return RedirectToPage("Users/Login");
            } else { 
                User = _loggedInUser.GetLoggedUser();
                return Page();
            }
        }
        public IActionResult OnPost() {
            Booking.UserId = _loggedInUser.GetLoggedUser().UserId;
            _bookingRepo.AddBooking(Booking);
            return RedirectToPage("Index");
        }
    }
}
