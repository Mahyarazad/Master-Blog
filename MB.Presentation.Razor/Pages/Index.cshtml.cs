using System.Collections.Generic;
using MB.Application.Contracts.Article;
using MB.Application.Contracts.Comment;
using MB.Domain.ArticleAgg;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IArticleApplication _articleApplication;
        private readonly ICommentApplication _commentApplication;
        public IndexModel(IArticleApplication articleApplication,
            ICommentApplication commentApplication)
        {
            _articleApplication = articleApplication;
            _commentApplication = commentApplication;
        }

        public List<ArticleViewModel> Articles { get; set; }
        public int CountComment { get; set; }
        public void OnGet()
        {
            Articles = _articleApplication.GetAll();
        }
    }
}