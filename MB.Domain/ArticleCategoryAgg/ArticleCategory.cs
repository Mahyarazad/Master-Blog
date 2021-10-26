using System;
using MB.Domain.ArticleCategoryAgg.Services;

namespace MB.Domain
{
    public class ArticleCategory
    {
        protected ArticleCategory()
        {

        }
        public ArticleCategory(string title, IArticleCategoryValidator validatorService)
        {
            GaurdAgaintEmptyAndNull(title);
            validatorService.CheckTheExistance(title);
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }

        public void GaurdAgaintEmptyAndNull(string title)
        {
            if (string.IsNullOrEmpty(title)) throw new ArgumentNullException();
        }

        public void EditTitle(string newTitle)
        {
            GaurdAgaintEmptyAndNull(newTitle);
            Title = newTitle;
        }

        public void Delete()
        {
            IsDeleted = true;
        }
        public void Reactivate()
        {
            IsDeleted = false;
        }
    }
}
