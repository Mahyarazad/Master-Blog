using System;
using System.Collections.Generic;
using _01_Framework.Repository;
using MB.Application.Contracts;
using MB.Domain;
using MB.Domain.ArticleCategoryAgg.Services;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidator _articleCategoryValidator;
        private readonly IUnitofWork _unitofWork;
        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository,
            IArticleCategoryValidator articleCategoryValidator,
            IUnitofWork unitofWork)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _articleCategoryValidator = articleCategoryValidator;
            _unitofWork = unitofWork;
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
                        Id = item.Id,
                        Title = item.Title,
                        IsDeleted = item.IsDeleted,
                        CreationDate = item.CreationTime.ToString()
                    });
            }

            return articlesViewModel;
        }

        public void Create(CreateArticleCategory commad)
        {
            _unitofWork.BeginTransaction();
            var article = new ArticleCategory(commad.Title, _articleCategoryValidator);
            _articleCategoryRepository.CreateAndSave(article);
            _unitofWork.CommitTransaction();
        }

        public void Edit(EditArticleCategory command)
        {
            _unitofWork.BeginTransaction();
            var article = _articleCategoryRepository.Get(command.Id);
            article.EditTitle(command.Title);
            _unitofWork.CommitTransaction();
        }

        public EditArticleCategory Get(int id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            return new EditArticleCategory
            {
                Id = articleCategory.Id,
                Title = articleCategory.Title
            };
        }

        public void Delete(int id)
        {
            _unitofWork.BeginTransaction();
            var article = _articleCategoryRepository.Get(id);
            article.Delete();
            _unitofWork.CommitTransaction();
        }

        public void Reactivate(int id)
        {
            _unitofWork.BeginTransaction();
            var article = _articleCategoryRepository.Get(id);
            article.Reactivate();
            _unitofWork.CommitTransaction();
        }
    }
}
