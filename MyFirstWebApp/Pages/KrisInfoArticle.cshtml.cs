using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstWebApp.Services;

namespace MyFirstWebApp.Pages
{
    public class KrisInfoArticleModel : PageModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Id { get; set; }
        public string Link { get; set; }
        private readonly IKrisInfoService KrisInfoService;

        public KrisInfoArticleModel(IKrisInfoService krisInfoService)
        {
            this.KrisInfoService = krisInfoService;
        }

        public void OnGet(string articleId)
        {
            var krisInfo = this.KrisInfoService.GetKrisInformation(articleId);
            Title = krisInfo.Title;
            Text = krisInfo.Text;
            Link = krisInfo.LinkUrl;
        }
    }
}
