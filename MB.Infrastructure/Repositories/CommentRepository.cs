using System.Collections.Generic;
using System.Linq;
using _01_Framework.Repository;
using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure
{
    public class CommentRepository : BaseRepository<int, Comment>, ICommentRepository
    {
        private readonly MBContext _mbContext;
        public CommentRepository(MBContext dbContext) : base(dbContext)
        {
            _mbContext = dbContext;
        }

        public void Confirm(int Id)
        {
            var comment = _mbContext.Comments.FirstOrDefault(x => x.Id == Id);
            comment.Confirm();
        }

        public void Delete(int Id)
        {
            var comment = _mbContext.Comments.FirstOrDefault(x => x.Id == Id);
            comment.Cancel();
        }

        public List<CommentViewModel> GetList()
        {
            return _mbContext.Comments.Include(x => x.Article).Select(x => new CommentViewModel
            {
                Id = x.Id,
                Email = x.Email,
                Status = x.Status,
                Name = x.Name,
                CreationDate = x.CreationTime.ToString(),
                Message = x.Message,
                Article = x.Article.Title
            }).ToList();
        }
    }
}