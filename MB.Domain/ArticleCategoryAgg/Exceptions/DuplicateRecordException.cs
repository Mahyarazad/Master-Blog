using System;

namespace MB.Domain.ArticleCategoryAgg.Exceptions
{
    public class DuplicateRecordException : Exception
    {
        public DuplicateRecordException(string message) : base(message)
        {

        }
    }
}
