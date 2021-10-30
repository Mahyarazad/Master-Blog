using System.Collections.Generic;
using _01_Framework.Repository;
using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        public ArticleApplication(IArticleRepository articleRepository,
            IUnitofWork unitofWork)
        {
            _articleRepository = articleRepository;
            _unitofWork = unitofWork;
        }

        private readonly IArticleRepository _articleRepository;
        private readonly IUnitofWork _unitofWork;

        public List<ArticleViewModel> GetAll()
        {
            return _articleRepository.GetList();
        }

        public void Create(CreateArticle command)
        {
            _unitofWork.BeginTransaction();
            var article = new Article(command.Title, command.ShortDescription, command.PictureUrl,
                command.Body, command.ArticleCategoryId);
            _articleRepository.CreateAndSave(article);
            _unitofWork.CommitTransaction();

        }

        public void Edit(EditArticle command)
        {
            _unitofWork.BeginTransaction();
            var article = _articleRepository.Get(command.ArticleId);
            article.Edit(command.Title, command.ShortDescription, command.PictureUrl, command.Body, command.ArticleCategoryId);
            _unitofWork.CommitTransaction();
        }

        public ArticleViewModel Get(int id)
        {
            var article = _articleRepository.Get(id);
            return new ArticleViewModel
            {
                Id = article.Id,
                Title = article.Title,
                ShortDescription = article.ShortDescription,
                PictureUrl = article.PictureUrl,
                Body = article.Body,
                ArticleCategoryId = article.ArticleCategory.Id,
            };
        }

        public void Delete(int id)
        {
            _unitofWork.BeginTransaction();
            var article = _articleRepository.Get(id);
            article.Delete();
            _unitofWork.CommitTransaction();
        }

        public void Reactivate(int id)
        {
            _unitofWork.BeginTransaction();
            var article = _articleRepository.Get(id);
            article.Reactivate();
            _unitofWork.CommitTransaction();
        }
    }
}