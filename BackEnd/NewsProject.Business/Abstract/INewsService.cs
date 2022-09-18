using Core.Utilities.Results;
using NewsProject.Entities.Concreate;
using NewsProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Business.Abstract
{
    public interface INewsService
    {
        IDataResult<News> GetById(int newsId);
        IDataResult<List<News>> GetList();
        IDataResult<List<News>> GetListByCategory(int categoryId);
        IDataResult<ResponseModel> Add(AddNewsDto news);
        IDataResult<ResponseModel> Update(UpdateNewsDto news);
        IResult Delete(DeleteNewsDto news);
    }
}
