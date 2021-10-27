using System;
using System.Collections.Generic;
using MB.Application.Contracts;
using MB.Domain;
using MB.Domain.ArticleCategoryAgg.Services;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidator _articleCategoryValidator;
        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository,
            IArticleCategoryValidator articleCategoryValidator)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _articleCategoryValidator = articleCategoryValidator;
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articles = _articleCategoryRepository.GetAll();
            var articlesViewModel = new List<ArticleCategoryViewModel>();
            foreach (var item in articles)
            {
                articlesViewModel.Add(
                    new ArticleCategoryViewModel
                    {
                        Id = item.ArticleCategoryId,
                        Title = item.Title,
                        IsDeleted = item.IsDeleted,
                        CreationDate = item.CreationDate.ToString()
                    });
            }

            return articlesViewModel;
        }

        public void Create(CreateArticleCategory commad)
        {
            var article = new ArticleCategory(commad.Title, _articleCategoryValidator);
            _articleCategoryRepository.Create(article);
        }

        public void Edit(EditArticleCategory command)
        {
            var article = _articleCategoryRepository.Get(command.Id);
            article.EditTitle(command.Title);
            _articleCategoryRepository.Save();
        }

        public EditArticleCategory Get(int id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            return new EditArticleCategory
            {
                Id = articleCategory.ArticleCategoryId,
                Title = articleCategory.Title
            };
        }

        public void Delete(int id)
        {
            var article = _articleCategoryRepository.Get(id);
            article.Delete();
            _articleCategoryRepository.Save();
        }

        public void Reactivate(int id)
        {
            var article = _articleCategoryRepository.Get(id);
            article.Reactivate();
            _articleCategoryRepository.Save();
        }
    }
}
