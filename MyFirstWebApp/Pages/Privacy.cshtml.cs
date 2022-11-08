using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MyFirstWebApp.Pages
{
    public class PrivacyModel : PageModel
    {
        CultureInfo ci = new CultureInfo("sv-SE");
        private readonly ILogger<PrivacyModel> _logger;
        public string info;
        public string currentWeekDay { get; set; }
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            info = "Denna sida måste inehålla information om våra policys";
            currentWeekDay = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();
        }
    }
}