using Core.Utilities.Results;
using NewsProject.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Business.Abstract
{
    public interface INewsCategoryService
    {
        IDataResult<List<NewsCategory>> GetList();
    }
}
