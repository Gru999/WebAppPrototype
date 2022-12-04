using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;

namespace WebAppPrototype.Pages.Bookings {
    public class CreateBookingModel : PageModel {
        private IBookingRepository _repo;
        [BindProperty]
        public Booking Booking { get; set; }
        public CreateBookingModel(IBookingRepository bookingRepo) {
            _repo = bookingRepo;
        }
        public IActionResult OnGet() {
            return Page();
        }
        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }
            _repo.AddBooking(Booking);
            return RedirectToPage("Index");
        }
    }
}
