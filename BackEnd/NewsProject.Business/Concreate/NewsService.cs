using Core.Utilities.Results;
using NewsProject.Business.Abstract;
using NewsProject.Business.Constants;
using NewsProject.Core.DAL.EntityFramework.UnitOfWork;
using NewsProject.DAL.Abstract;
using NewsProject.Entities.Concreate;
using NewsProject.Entities.Dtos;

namespace NewsProject.Business.Concreate
{
    public class NewsService : INewsService
    {
        private readonly INewsDal _newsDal;
        private readonly IUnitOfWork _unitOfWork;

        public NewsService(INewsDal newsDal, IUnitOfWork unitOfWork)
        {
            _newsDal = newsDal;
            _unitOfWork = unitOfWork;
        }

        public IDataResult<ResponseModel> Add(AddNewsDto addNewsDto)
        {
            News news = new News()
            {
                NewsHeader = addNewsDto.NewsHeader,
                NewsContext = addNewsDto.NewsContext,
                NewsCategoryId = Convert.ToInt32(addNewsDto.NewsCategoryId),
                PhotoUrl = addNewsDto.PhotoUrl
            };
            _newsDal.AddAsync(news);
            _unitOfWork.Commit();
            return new SuccessDataResult<ResponseModel>(Messages.NewsAdded);
        }

        public IResult Delete(DeleteNewsDto deleteNewsDto)
        {

            News news = new News()
            {
                Id = deleteNewsDto.Id,
                IsDeleted = deleteNewsDto.IsDeleted,
                DeletedDate = deleteNewsDto.DeletedDate,
                NewsCategoryId=deleteNewsDto.NewsCategoryId,
                NewsContext = deleteNewsDto.NewsContext,
                NewsHeader = deleteNewsDto.NewsHeader,
                PhotoUrl = deleteNewsDto.PhotoUrl
            };
            _newsDal.Update(news);
            _unitOfWork.Commit();
            return new SuccessResult(Messages.NewsDeleted);
        }

        public IDataResult<News> GetById(int newsId)
        {
            return _newsDal.Get(x => x.Id == newsId) != null ? new SuccessDataResult<News>(_newsDal.Get(n => n.Id == newsId)) : new ErrorDataResult<News>(Messages.NewsNotFound);
        }

        public IDataResult<List<News>> GetList()
        {
            return new SuccessDataResult<List<News>>(_newsDal.GetList(x => x.IsDeleted == false).ToList());
        }

        public IDataResult<List<News>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<News>>(_newsDal.GetList(l => l.NewsCategoryId == categoryId && l.IsDeleted == false).ToList());
        }

        public IDataResult<ResponseModel> Update(UpdateNewsDto updateNewsDto)
        {
            News news = new News()
            {
                Id = updateNewsDto.Id,
                NewsHeader = updateNewsDto.NewsHeader,
                NewsCategoryId =Convert.ToInt32(updateNewsDto.NewsCategoryId),
                NewsContext = updateNewsDto.NewsContext,
                PhotoUrl = updateNewsDto.PhotoUrl,
            };
            _newsDal.Update(news);
            _unitOfWork.Commit();
            return new SuccessDataResult<ResponseModel>(Messages.NewsUpdated);
        }
    }
}
