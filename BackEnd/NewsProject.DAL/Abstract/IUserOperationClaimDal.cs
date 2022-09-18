using Core.Entities.Concreate;
using NewsProject.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.DAL.Abstract
{
    public interface IUserOperationClaimDal:IEntityRepository<UserOperationClaim>
    {
    }
}
