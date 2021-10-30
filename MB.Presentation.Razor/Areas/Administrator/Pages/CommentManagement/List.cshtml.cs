using System.Collections.Generic;
using MB.Application.Contracts.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.Razor.Areas.Administrator.Pages.CommentManagement
{
    public class ListModel : PageModel
    {
        private readonly ICommentApplication _commentApplication;

        public ListModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }

        public List<CommentViewModel> Comments { get; set; }
        public void OnGet()
        {
            Comments = _commentApplication.GetList();
        }
        public IActionResult OnPostConfirm(int Id)
        {
            _commentApplication.Confirm(Id);
            return RedirectToPage("./List");
        }
        public IActionResult OnPostCancel(int Id)
        {
            _commentApplication.Delete(Id);
            return RedirectToPage("./List");
        }
    }
}
