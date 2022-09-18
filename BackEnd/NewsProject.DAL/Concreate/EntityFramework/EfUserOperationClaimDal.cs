using Core.Entities.Concreate;
using NewsProject.DAL.Abstract;
using NewsProject.DAL.Concreate.EntityFramework.DbContexts;
using NewsProject.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.DAL.Concreate.EntityFramework
{
    public class EfUserOperationClaimDal : EntityRepositoryBase<UserOperationClaim>, IUserOperationClaimDal
    {
        public EfUserOperationClaimDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
