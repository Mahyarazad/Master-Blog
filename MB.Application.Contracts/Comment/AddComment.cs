namespace MB.Application.Contracts.Comment
{
    public class AddComment
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public int ArticleId { get; set; }
    }
}