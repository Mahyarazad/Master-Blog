namespace MB.Application.Contracts.Article
{
    public class CreateArticle
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string PictureUrl { get; set; }
        public string Body { get; set; }
        public int ArticleCategoryId { get; set; }
    }
}