using System;
using System.Collections.Generic;

namespace MB.Application.Contracts
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();
        void Create(CreateArticleCategory commad);
        void Edit(EditArticleCategory command);
        EditArticleCategory Get(int id);
        void Delete(int id);
        void Reactivate(int id);
    }
}
