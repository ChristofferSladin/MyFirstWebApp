using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstWebApp.Pages
{
    public class NewsModel : PageModel
    {
        public class NewListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

        public List<NewListItem> Items { get; set; }
        public void OnGet()
        {
            Items = new List<NewListItem>()
            {
                new NewListItem{Title = "Cat saved from tree", Description = "hbjdsbbdbhdbshbbkdfsbkj"},
                new NewListItem{Title = "Elderly helped over the road", Description = "hbjdsbbdbhdbshbbkdfsbkj"},
                new NewListItem{Title = "New study shows increased living standard", Description = "hbjdsbbdbhdbshbbkdfsbkj"},
                new NewListItem{Title = "10 Fun News", Description = "hbjdsbbdbhdbshbbkdfsbkj"}
            };
        }
    }
}
