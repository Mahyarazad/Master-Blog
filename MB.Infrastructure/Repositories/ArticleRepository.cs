using MB.Domain.ArticleAgg;

namespace MB.Infrastructure
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MBContext _mbContext;

        public ArticleRepository(MBContext mbContext)
        {
            _mbContext = mbContext;
        }

        public void create(Article entity)
        {
            throw new System.NotImplementedException();
        }
    }
}