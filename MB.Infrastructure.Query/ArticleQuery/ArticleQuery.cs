using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using MB.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace MB.Application.Contracts.Article
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly MBContext _mbContext;

        public ArticleQuery(MBContext mbContext)
        {
            _mbContext = mbContext;
        }

        public ArticleQueryView Get(int id)
        {
            return _mbContext.Articles
                .Include(x => x.ArticleCategory)
                .Include(x => x.Comments)
                .Select(x => new ArticleQueryView
                {
                    Id = x.Id,
                    Body = x.Body,
                    PictureUrl = x.PictureUrl,
                    CreationTime = x.CreationTime.ToString(CultureInfo.CurrentCulture),
                    ShortDescription = x.ShortDescription,
                    Title = x.Title,
                    ArticleCategory = x.ArticleCategory,
                    Comments = x.Comments
                }).FirstOrDefault(x => x.Id == id);
        }
    }
}