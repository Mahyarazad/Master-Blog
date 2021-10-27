using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Razor.Pages
{
    public class ArticleDetailModel : PageModel
    {
        private readonly IArticleApplication _articleApplication;
        public EditArticle Article { get; set; }
        public ArticleDetailModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }

        public void OnGet(int id)
        {
            Article = _articleApplication.Get(id);
        }
    }
}
