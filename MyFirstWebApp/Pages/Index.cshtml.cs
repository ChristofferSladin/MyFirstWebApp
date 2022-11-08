using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstWebApp.Services;

namespace MyFirstWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public DateTime Nu { get; set; }

        public string message;

        public List<HockeyPlayers> AllPlayers { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            message = "Hello World";
            AllPlayers = new HockeyService().GetAllPlayers();

            Nu = DateTime.Now;

        }
    }
}