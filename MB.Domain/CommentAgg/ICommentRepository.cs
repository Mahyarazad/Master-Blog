using System.Collections.Generic;
using _01_Framework.Repository;
using MB.Application.Contracts.Comment;

namespace MB.Domain.CommentAgg
{
    public interface ICommentRepository : IRepository<int, Comment>
    {
        void Confirm(int Id);
        void Delete(int Id);
        List<CommentViewModel> GetList();
    }
}