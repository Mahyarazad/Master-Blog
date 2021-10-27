using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application;
using MB.Application.Contracts;
using MB.Application.Contracts.Article;
using MB.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentation.Razor.Areas.Administrator.Pages.ArticleManagement
{
    public class CreateModel : PageModel
    {
        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCategoryApplication _articleCategoryApplication;
        public List<SelectListItem> Categories { get; set; }
        public CreateModel(IArticleApplication articleApplication,
            IArticleCategoryApplication articleCategoryApplication)
        {
            _articleApplication = articleApplication;
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
            Categories = _articleCategoryApplication.List().Select(x => new SelectListItem(
                x.Title, x.Id.ToString())).ToList();
        }
        public IActionResult OnPost(CreateArticle command)
        {
            _articleApplication.Create(command);
            return RedirectToPage("./Index");
        }
    }
}
