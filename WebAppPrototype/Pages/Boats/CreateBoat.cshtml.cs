using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;

namespace WebAppPrototype.Pages.Boats
{
    public class CreateBoatModel : PageModel
    {
        private IBoatRepository _repo;
        [BindProperty]
        public Boat Boat { get; set; }
        public CreateBoatModel(IBoatRepository repo)
        {
            _repo = repo;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            _repo.AddBoat(Boat);
            return RedirectToPage("Index");
        }
    }
}
