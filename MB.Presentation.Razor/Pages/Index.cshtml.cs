using System.Collections.Generic;
using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public List<ArticleViewModel> Articles { get; set; }
        private readonly IArticleApplication _articleApplication;
        public void OnGet()
        {
            Articles = _articleApplication.GetAll();
        }
    }
}