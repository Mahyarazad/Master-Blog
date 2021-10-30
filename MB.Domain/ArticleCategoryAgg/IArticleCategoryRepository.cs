using System.Collections.Generic;
using _01_Framework.Repository;

namespace MB.Domain
{
    public interface IArticleCategoryRepository : IRepository<int, ArticleCategory>
    {
        bool Exist(string title);
    }
}
