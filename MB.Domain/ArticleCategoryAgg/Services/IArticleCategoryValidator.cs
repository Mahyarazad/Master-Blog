namespace MB.Domain.ArticleCategoryAgg.Services
{
    public interface IArticleCategoryValidator
    {
        void CheckTheExistance(string title);
    }
}
