using NewsProject.Core.DAL.EntityFramework.UnitOfWork;
using NewsProject.DAL.Concreate.EntityFramework.DbContexts;

namespace NewsProject.DAL.Concreate.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
