namespace MB.Domain.ArticleAgg.Services
{
    public interface IArticleValidator
    {
        void CheckTheExistance(string title);
    }

}