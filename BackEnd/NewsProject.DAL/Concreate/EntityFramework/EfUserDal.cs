using Core.Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using NewsProject.Core.Entities;
using NewsProject.Core.Entities.Concreate;
using NewsProject.DAL.Abstract;
using NewsProject.DAL.Concreate.EntityFramework.DbContexts;
using NewsProject.Entities.Concreate;

namespace NewsProject.DAL.Concreate.EntityFramework
{
    public class EfUserDal : EntityRepositoryBase<User>, IUserDal
    {
        protected readonly AppDbContext _appDbContext;
        public EfUserDal(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            var result = from operationClaim in _appDbContext.OperationClaims
                         join userOperationClaim in _appDbContext.UserOperationClaims
                         on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.Id
                         select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
            return result.ToList();
        }
    }
}
