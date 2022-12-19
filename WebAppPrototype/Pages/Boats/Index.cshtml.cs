using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebAppPrototype.Models;
using WebAppPrototype.Interfaces;

namespace WebAppPrototype.Pages.Boats
{
    public class IndexModel : PageModel
    {
        private IBoatRepository _repo;
        public List<Boat> Boats { get; private set; }
        public IndexModel(IBoatRepository repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
            Boats = _repo.GetAllBoats();
        }
    }
}
