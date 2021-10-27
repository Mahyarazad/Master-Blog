using System.Collections.Generic;
using MB.Application.Contracts.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Razor.Areas.Administrator.Pages.ArticleManagement
{
    public class IndexModel : PageModel
    {
        public List<ArticleViewModel> Articles { get; set; }
        private readonly IArticleApplication _articleApplication;

        public IndexModel(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }
        public void OnGet()
        {
            Articles = _articleApplication.GetAll();
        }
        public IActionResult OnPostDelete(int Id)
        {
            _articleApplication.Delete(Id);
            return RedirectToPage("./Index");
        }
        public IActionResult OnPostReactivate(int Id)
        {
            _articleApplication.Reactivate(Id);
            return RedirectToPage("./Index");
        }
    }
}
