using System.Collections.Generic;
using _01_Framework.Repository;
using MB.Application.Contracts.Article;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository : IRepository<int, Article>
    {
        List<ArticleViewModel> GetList();
        bool Exist(string title);
    }
}