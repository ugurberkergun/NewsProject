using Core.Entities.Concreate;
using Core.Utilities.Results;
using NewsProject.Business.Abstract;
using NewsProject.Business.Constants;
using NewsProject.Core.DAL.EntityFramework.UnitOfWork;
using NewsProject.DAL.Abstract;
using NewsProject.Entities.Concreate;
using NewsProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Business.Concreate
{
    public class UserOperationClaimService : IUserOperationClaimService
    {
        private readonly IUserOperationClaimDal _userOperationClaimDal;
        private readonly IUnitOfWork _unitOfWork;

        public UserOperationClaimService(IUnitOfWork unitOfWork, IUserOperationClaimDal userOperationClaimDal)
        {
            _unitOfWork = unitOfWork;
            _userOperationClaimDal = userOperationClaimDal;
        }

        public IResult Add(UserOperationClaim userOperationClaim)
        {
            _userOperationClaimDal.AddAsync(userOperationClaim);
            _unitOfWork.Commit();
            return new SuccessResult(Messages.OperationClaimDefined);
        }
    }
}
