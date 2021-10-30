using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using _01_Framework.Repository;
using MB.Domain;

namespace MB.Infrastructure
{
    public class ArticleCategoryRepository : BaseRepository<int, ArticleCategory>, IArticleCategoryRepository
    {
        private readonly MBContext _context;
        public ArticleCategoryRepository(MBContext context) : base(context)
        {
            _context = context;
        }

        public void Create(ArticleCategory entity)
        {
            _context.ArticleCategories.Add(entity);
        }


        public bool Exist(string title)
        {
            return _context.ArticleCategories.Any(x => x.Title == title);
        }
    }
}
