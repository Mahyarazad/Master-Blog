using System.Collections.Generic;
using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        public ArticleApplication(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        private readonly IArticleRepository _articleRepository;

        public List<ArticleViewModel> GetAll()
        {
            return _articleRepository.GetAll();
        }

        public void Create(CreateArticle command)
        {
            var article = new Article(command.Title, command.ShortDescription, command.PictureUrl,
                command.Body, command.ArticleCategoryId);
            _articleRepository.CreateAndSave(article);

        }

        public void Edit(EditArticle command)
        {
            var article = _articleRepository.Get(command.ArticleId);
            article.Edit(command.Title, command.ShortDescription, command.PictureUrl, command.Body, command.ArticleCategoryId);
            _articleRepository.Save();
        }

        public EditArticle Get(int id)
        {
            var article = _articleRepository.Get(id);
            return new EditArticle
            {
                ArticleId = article.ArticleId,
                Title = article.Title,
                ShortDescription = article.ShortDescription,
                PictureUrl = article.PictureUrl,
                Body = article.Body,
                ArticleCategoryId = article.ArticleCategoryId,
            };
        }

        public void Delete(int id)
        {
            var article = _articleRepository.Get(id);
            article.Delete();
            _articleRepository.Save();
        }

        public void Reactivate(int id)
        {
            var article = _articleRepository.Get(id);
            article.Reactivate();
            _articleRepository.Save();
        }
    }
}