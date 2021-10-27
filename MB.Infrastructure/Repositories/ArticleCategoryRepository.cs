using System.Collections.Generic;
using System.Linq;
using MB.Domain;

namespace MB.Infrastructure
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MBContext _context;
        public ArticleCategoryRepository(MBContext context)
        {
            _context = context;
        }

        public void Create(ArticleCategory entity)
        {
            _context.ArticleCategories.Add(entity);
            Save();

        }

        public List<ArticleCategory> GetAll()
        {
            return _context.ArticleCategories.OrderByDescending(x => x.ArticleCategoryId).ToList();
        }

        public ArticleCategory Get(int id)
        {
            return _context.ArticleCategories.FirstOrDefault(x => x.ArticleCategoryId == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        public bool Exist(string title)
        {
            return _context.ArticleCategories.Any(x => x.Title == title);
        }

    }
}
