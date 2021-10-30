using _01_Framework.Repository;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure
{
    public class UnitofWork : IUnitofWork
    {
        private readonly MBContext _context;

        public UnitofWork(MBContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _context.SaveChanges();
            _context.Database.CommitTransaction();
        }

        public void RollBack()
        {
            _context.Database.RollbackTransaction();
        }
    }
}