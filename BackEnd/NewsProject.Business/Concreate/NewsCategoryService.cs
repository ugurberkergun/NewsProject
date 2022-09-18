using Core.Utilities.Results;
using NewsProject.Business.Abstract;
using NewsProject.DAL.Abstract;
using NewsProject.DAL.Concreate.EntityFramework;
using NewsProject.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Business.Concreate
{
    public class NewsCategoryService : INewsCategoryService
    {
        private readonly INewsCategoryDal _newsCategoryDal;

        public NewsCategoryService(INewsCategoryDal newsCategoryDal)
        {
            _newsCategoryDal = newsCategoryDal;
        }

        public IDataResult<List<NewsCategory>> GetList()
        {
            return new SuccessDataResult<List<NewsCategory>>(_newsCategoryDal.GetList().ToList());
        }
    }
}
