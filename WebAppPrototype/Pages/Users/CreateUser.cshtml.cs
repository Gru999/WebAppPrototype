using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppPrototype.Models;
using WebAppPrototype.Interfaces;
using System.Diagnostics.Metrics;

namespace WebAppPrototype.Pages.Users {
    public class CreateUserModel : PageModel {
        private IUserRepository _repo;
        public string AccessDenied = "";
        [BindProperty]
        public User User { get; set; }

        public CreateUserModel(IUserRepository repo) {
            _repo = repo;
        }
        public IActionResult OnGet() {
            return Page();
        }
        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }
            _repo.AddUser(User);
            return RedirectToPage("Index");
        }
    }
}
