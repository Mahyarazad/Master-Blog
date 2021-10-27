using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure
{
    public class ArticleRepository : IArticleRepository<ArticleViewModel>
    {
        private readonly MBContext _mbContext;

        public ArticleRepository(MBContext mbContext)
        {
            _mbContext = mbContext;
        }

        public void CreateAndSave(Article entity)
        {
            _mbContext.Add(entity);
            Save();
        }

        public List<ArticleViewModel> GetAll()
        {
            return _mbContext.Articles.Include(x => x.ArticleCategory)
                .Select(x => new ArticleViewModel
                {
                    Id = x.ArticleId,
                    Title = x.Title,
                    ShortDescription = x.ShortDescription,
                    PictureUrl = x.PictureUrl,
                    CreationTime = x.CreationTime.ToString(),
                    IsDeleted = x.IsDeleted
                }).ToList();
        }

        public Article Get(int id)
        {
            return _mbContext.Articles.FirstOrDefault(x => x.ArticleId == id);
        }

        public void Save()
        {
            _mbContext.SaveChanges();
        }

        public bool Exist(string title)
        {
            return _mbContext.Articles.Any(x => x.Title == title);
        }
    }
}