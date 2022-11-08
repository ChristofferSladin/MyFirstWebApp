using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstWebApp.Services;

namespace MyFirstWebApp.Pages
{
    public class PlayersModel : PageModel
    {
        public List<HockeyPlayers> AllPlayers { get; set; }
        public void OnGet()
        {
            AllPlayers = new HockeyService().GetAllPlayers();
        }
    }
}
