using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsProject.Business.Abstract;
using NewsProject.Entities.Concreate;
using NewsProject.Entities.Dtos;
using System.Data;

namespace NewsProject.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetList()
        {
            var result = _newsService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]

        public IActionResult GetListByCategory(int categoryId)
        {
            var result = _newsService.GetListByCategory(categoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]

        public IActionResult GetById(int newsId)
        {
            var result = _newsService.GetById(newsId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]

        public IActionResult Add(AddNewsDto news)
        {
            var result = _newsService.Add(news);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]

        public IActionResult Update(UpdateNewsDto news)
        {
            var result = _newsService.Update(news);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]

        public IActionResult Delete(DeleteNewsDto news)
        {
            var result = _newsService.Delete(news);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
