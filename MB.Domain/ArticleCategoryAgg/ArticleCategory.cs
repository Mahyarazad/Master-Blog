using System;
using System.Collections.Generic;
using _01_Framework;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg.Services;

namespace MB.Domain
{
    public class ArticleCategory : DomainBase<int>
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
            Articles = new List<Article>();
        }

        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public ICollection<Article> Articles { get; set; }
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
