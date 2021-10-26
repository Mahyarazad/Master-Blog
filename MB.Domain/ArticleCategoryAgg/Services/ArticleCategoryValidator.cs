using System;
using System.Data;

namespace MB.Domain.ArticleCategoryAgg.Services
{
    public class ArticleCategoryValidator : IArticleCategoryValidator
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryValidator(IArticleCategoryRepository articleCategoryRepository)
        {
            articleCategoryRepository = _articleCategoryRepository;
        }

        public void CheckTheExistance(string title)
        {
            if (_articleCategoryRepository.Exist(title))
                throw new DuplicateNameException("This record already exists in database");
        }
    }
}