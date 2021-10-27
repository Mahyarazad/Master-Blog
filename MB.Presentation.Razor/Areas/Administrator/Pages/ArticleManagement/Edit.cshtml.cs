using System.Collections.Generic;
using System.Linq;
using MB.Application.Contracts;
using MB.Application.Contracts.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentation.Razor.Areas.Administrator.Pages.ArticleManagement
{
    public class EditModel : PageModel
    {
        [BindProperty] public EditArticle Article { get; set; }
        public List<SelectListItem> Categories { get; set; }
        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public EditModel(IArticleApplication articleApplication,
            IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
            _articleApplication = articleApplication;
        }

        public void OnGet(int id)
        {
            Categories = _articleCategoryApplication.List().Select(x =>
                new SelectListItem(x.Title, x.Id.ToString())).ToList();
            var article = _articleApplication.Get(id);
            Article = new EditArticle
            {
                ShortDescription = article.ShortDescription,
                ArticleId = article.Id,
                Body = article.Body,
                Title = article.Title,
                PictureUrl = article.PictureUrl,
                ArticleCategoryId = article.ArticleCategoryId
            };
        }

        public IActionResult OnPost()
        {
            _articleApplication.Edit(Article);
            return RedirectToPage("./Index");
        }
    }
}
