using System.Collections.Generic;

namespace MB.Application.Contracts.Article
{
    public interface IArticleApplication
    {
        List<ArticleViewModel> GetAll();
        void Create(CreateArticle command);
        void Edit(EditArticle command);
        ArticleViewModel Get(int id);
        void Delete(int id);
        void Reactivate(int id);
    }
}