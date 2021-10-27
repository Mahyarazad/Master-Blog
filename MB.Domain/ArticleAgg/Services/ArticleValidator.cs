using System.Data;

namespace MB.Domain.ArticleAgg.Services
{
    public class ArticleValidator
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleValidator(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void CheckTheExistance(string title)
        {
            if (_articleRepository.Exist(title))
                throw new DuplicateNameException("This record already exists in database");
        }
    }
}
