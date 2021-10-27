using System;

namespace MB.Application.Contracts.Article
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string PictureUrl { get; set; }
        public string CreationTime { get; set; }
        public bool IsDeleted { get; set; }
        public int ArticleCategoryId { get; set; }
        public string ArticleCategory { get; set; }
        public string Body { get; set; }
    }
}