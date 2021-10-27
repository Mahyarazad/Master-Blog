namespace MB.Application.Contracts.Article
{
    public interface IArticleQuery
    {
        ArticleQueryView Get(int id);
    }
}