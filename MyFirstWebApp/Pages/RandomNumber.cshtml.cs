using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstWebApp.Pages
{
    public class RandomNumberModel : PageModel
    {
        public int RandomNumber { get; set; }
        public void OnGet()
        {
            var num = new Random();
            RandomNumber = num.Next(0,300000);

        }
    }
}
