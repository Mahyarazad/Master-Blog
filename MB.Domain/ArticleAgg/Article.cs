using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using _01_Framework;
using MB.Domain.CommentAgg;

namespace MB.Domain.ArticleAgg
{
    public class Article : DomainBase<int>
    {
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string PictureUrl { get; private set; }
        public string Body { get; private set; }
        public bool IsDeleted { get; private set; }
        public int ArticleCategoryId { get; private set; }
        public ArticleCategory ArticleCategory { get; private set; }
        public ICollection<Comment> Comments { get; private set; }
        protected Article()
        {

        }
        public Article(string title, string shortDescription, string pictureUrl, string body, int categoryId)
        {
            Validator(title, categoryId);
            Title = title;
            ShortDescription = shortDescription;
            PictureUrl = pictureUrl;
            Body = body;
            ArticleCategoryId = categoryId;
            IsDeleted = false;
            Comments = new List<Comment>();
        }

        private static void Validator(string title, int categoryId)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException();
            if (categoryId == 0)
                throw new ArgumentOutOfRangeException();
        }

        public void Edit(string title, string shortDescription, string pictureUrl, string body, int categoryId)
        {
            Validator(title, categoryId);
            Title = title;
            ShortDescription = shortDescription;
            PictureUrl = pictureUrl;
            Body = body;
            ArticleCategoryId = categoryId;
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
