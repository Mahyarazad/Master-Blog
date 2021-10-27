using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts;
using MB.Application.Contracts.Article;
using MB.Domain;
using MB.Domain.ArticleAgg;
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
            Article = _articleApplication.Get(id);
        }

        public IActionResult OnPost()
        {
            _articleApplication.Edit(Article);
            return RedirectToPage("./Index");
        }
    }
}
