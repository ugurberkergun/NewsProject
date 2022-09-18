using Core.Entities.Concreate;
using NewsProject.Business.Abstract;
using NewsProject.Core.DAL.EntityFramework.UnitOfWork;
using NewsProject.Core.Entities.Concreate;
using NewsProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Business.Concreate
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserDal userDal, IUnitOfWork unitOfWork)
        {
            _userDal = userDal;
            _unitOfWork = unitOfWork;
        }

        public void Add(User user)
        {
            _userDal.AddAsync(user);
            _unitOfWork.Commit();
        }

        public User GetByEmail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
    }
}
