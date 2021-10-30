using System;

namespace _01_Framework
{
    public class DomainBase<T>
    {
        public T Id { get; private set; }
        public DateTime CreationTime { get; private set; }

        public DomainBase()
        {
            CreationTime = DateTime.Now;
        }
    }
}
