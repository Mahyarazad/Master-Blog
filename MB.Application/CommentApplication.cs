using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;
using System.Collections.Generic;
using _01_Framework.Repository;
using MB.Application.Contracts.Article;

namespace MB.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IUnitofWork _unitofWork;

        public CommentApplication(ICommentRepository commentRepository,
            IUnitofWork unitofWork)
        {
            _commentRepository = commentRepository;
            _unitofWork = unitofWork;
        }


        public void Add(AddComment command)
        {
            _unitofWork.BeginTransaction();
            var comment = new Comment(command.Name, command.Email, command.Message, command.ArticleId);
            _commentRepository.CreateAndSave(comment);
            _unitofWork.CommitTransaction();

        }

        public List<CommentViewModel> GetList()
        {
            return _commentRepository.GetList();
        }

        public void Confirm(int Id)
        {
            _unitofWork.BeginTransaction();
            _commentRepository.Confirm(Id);
            _unitofWork.CommitTransaction();
        }

        public void Delete(int Id)
        {
            _unitofWork.BeginTransaction();
            _commentRepository.Delete(Id);
            _unitofWork.CommitTransaction();
        }
    }
}