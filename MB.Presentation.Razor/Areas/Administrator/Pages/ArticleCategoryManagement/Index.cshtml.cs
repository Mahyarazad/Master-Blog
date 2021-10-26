using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application;
using MB.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Razor.Areas.Administrator.Pages.ArticleCategoryManagement
{
    public class IndexModel : PageModel
    {
        public List<ArticleCategoryViewModel> ArticleCategories { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public IndexModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
            ArticleCategories = _articleCategoryApplication.List();
        }

        public IActionResult OnPostDelete(int Id)
        {
            _articleCategoryApplication.Delete(Id);
            return RedirectToPage("./Index");
        }
        public IActionResult OnPostReactivate(int Id)
        {
            _articleCategoryApplication.Reactivate(Id);
            return RedirectToPage("./Index");
        }
    }
}
