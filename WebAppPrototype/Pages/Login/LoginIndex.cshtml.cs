using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppPrototype.Pages.Login
{
    public class LoginIndexModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Email { get; set; }
        public void OnGet()
        {
        }
        public void OnPost() { 
            
        }
    }
}
