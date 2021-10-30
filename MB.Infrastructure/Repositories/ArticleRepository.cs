using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using _01_Framework;
using _01_Framework.Repository;
using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;
using MB.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure
{
    public class ArticleRepository : BaseRepository<int, Article>, IArticleRepository
    {
        private readonly MBContext _mbContext;
        public ArticleRepository(MBContext dbContext) : base(dbContext)
        {
            _mbContext = dbContext;
        }

        public List<ArticleViewModel> GetList()
        {
            return _mbContext.Articles
                .Include(x => x.ArticleCategory)
                .Include(x => x.Comments)
                .Select(x => new ArticleViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    ShortDescription = x.ShortDescription,
                    PictureUrl = x.PictureUrl,
                    CreationTime = x.CreationTime.ToString(CultureInfo.CurrentCulture),
                    IsDeleted = x.IsDeleted,
                    ArticleCategory = x.ArticleCategory.Title,
                    Comments = x.Comments.Count(x => x.Status == StatusHelper.Confirmed)
                })
                .OrderByDescending(x => x.Id).ToList();
        }

        public bool Exist(string title)
        {
            return _mbContext.Articles.Any(x => x.Title == title);
        }
    }
}