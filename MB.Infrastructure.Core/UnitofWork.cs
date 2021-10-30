using _01_Framework.Repository;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.Core
{
    public class UnitofWork : IUnitofWork
    {
        private readonly DbContext _context;

        public UnitofWork(DbContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _context.Database.CommitTransaction();
        }

        public void RollBack()
        {
            _context.Database.RollbackTransaction();
        }
    }
}