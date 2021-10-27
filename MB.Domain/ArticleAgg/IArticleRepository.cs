using System.Collections.Generic;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository<ArticleViewModel>
    {
        void CreateAndSave(Article entity);
        List<ArticleViewModel> GetAll();
        Article Get(int id);
        void Save();
        bool Exist(string title);
    }
}