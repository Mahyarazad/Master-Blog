using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application;
using MB.Application.Contracts;
using MB.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Razor.Areas.Administrator.Pages.ArticleCategoryManagement
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public EditArticleCategory ViewModel { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public EditModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(EditArticleCategory command)
        {
            ViewModel = _articleCategoryApplication.Get(command.Id);
        }
        public IActionResult OnPost(EditArticleCategory command)
        {
            _articleCategoryApplication.Edit(command);
            return RedirectToPage("./Index");
        }
    }

}
