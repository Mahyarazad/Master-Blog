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
        private readonly IArticleQuery _articleQuery;

        public ArticleDetailModel(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public ArticleQueryView Article { get; set; }

        public void OnGet(int id)
        {
            Article = _articleQuery.Get(id);
        }
    }
}
