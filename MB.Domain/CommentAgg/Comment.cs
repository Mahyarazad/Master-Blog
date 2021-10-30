using System;
using _01_Framework;
using MB.Domain.ArticleAgg;

namespace MB.Domain.CommentAgg
{
    public class Comment : DomainBase<int>
    {
        public Comment(string name, string email, string message, int articleId)
        {
            Name = name;
            Email = email;
            Message = message;
            ArticleId = articleId;
            Status = StatusHelper.New;
        }

        protected Comment()
        {
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public int Status { get; private set; } // 0 New - 1 Confirmed - 2 Canceled
        public int ArticleId { get; private set; }
        public Article Article { get; private set; }

        public void Confirm()
        {
            Status = StatusHelper.Confirmed;
        }
        public void Cancel()
        {
            Status = StatusHelper.Canceled;
        }
    }
}