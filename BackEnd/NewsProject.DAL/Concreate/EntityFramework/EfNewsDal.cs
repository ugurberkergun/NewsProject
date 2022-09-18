using NewsProject.DAL.Abstract;
using NewsProject.DAL.Concreate.EntityFramework.DbContexts;
using NewsProject.Entities.Concreate;

namespace NewsProject.DAL.Concreate.EntityFramework
{
    public class EfNewsDal : EntityRepositoryBase<News>, INewsDal
    {
        public EfNewsDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
