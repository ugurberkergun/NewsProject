using NewsProject.DAL.Abstract;
using NewsProject.DAL.Concreate.EntityFramework.DbContexts;
using NewsProject.Entities.Concreate;

namespace NewsProject.DAL.Concreate.EntityFramework
{
    public class EfNewsCategoryDal : EntityRepositoryBase<NewsCategory>, INewsCategoryDal
    {
        public EfNewsCategoryDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
