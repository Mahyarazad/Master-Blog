using System.Collections.Generic;

namespace MB.Domain
{
    public interface IArticleCategoryRepository
    {
        void Create(ArticleCategory entity);
        List<ArticleCategory> GetAll();
        ArticleCategory Get(int id);
        void Save();
        bool Exist(string title);
    }
}
