using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstWebApp.Services;


namespace MyFirstWebApp.Pages
{
    public class KrisInfoListaModel : PageModel
    {
        private readonly IKrisInfoService KrisInfoService;

        public KrisInfoListaModel(IKrisInfoService KrisInfoService)
        {
            this.KrisInfoService = KrisInfoService;
        }
        public List<NewsListItem> Items { get; set; }

        public class NewsListItem
        {
            public string Title { get; set; }
            public string Text { get; set; }
            public string Id { get; set; }
        }

        public void OnPost(string query)
        {
            if (query != null)
            {
                Items = KrisInfoService.GetAllKrisInformation().Select(r => new NewsListItem
                {
                    Title = r.Title,
                    Text = r.Text,
                    Id = r.Id

                }).Where(k => k.Title.ToLower().Contains(query.ToLower()) || k.Id.ToLower().Contains(query.ToLower())).ToList();

            }
            if (query == null)
            {
                Items = KrisInfoService.GetAllKrisInformation().Select(i => new NewsListItem
                {
                    Id = "",
                    Title = "",
                    Text = ""
                }).ToList();
            }

        }
        public void OnGet()
        {
            Items = this.KrisInfoService.GetAllKrisInformation().Select(r => new NewsListItem
            {
                Title = r.Title,
                Text = r.Text,
                Id = r.Id
            }).ToList();
        }
    }
}

