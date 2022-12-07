using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;
using WebAppPrototype.Services;

namespace WebAppPrototype.Pages.Users
{
    public class IndexModel : PageModel
    {
        private IUserRepository userRepository;
        private LogInRepository logInRepository;
        public string AccessDenied = "";
        [BindProperty]
        public User User { get; set; }

        public LoginModel(IUserRepository repo, LogInRepository logIn)
        {
            userRepository = repo;
            logInRepository = logIn;

        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            foreach(var user in userRepository.GetAllUsers())
            {
                if (user.Email == User.Email) {
                    if (user.Password == User.Password) {
                        logInService.UserLogIn(user);
                        return RedirectToPage("/Index");
                    }
                }
                AccessDenied = "Email or Password are wrong";
            }
            return Page();
        }
    }
}
