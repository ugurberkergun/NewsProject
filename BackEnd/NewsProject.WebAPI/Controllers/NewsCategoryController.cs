using Core.Utilities.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsProject.Business.Abstract;
using System.Data;

namespace NewsProject.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NewsCategoryController : ControllerBase
    {
        private readonly INewsCategoryService _newsCategoryService;

        public NewsCategoryController(INewsCategoryService newsCategoryService)
        {
            _newsCategoryService = newsCategoryService;
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]

        public IActionResult GetNewsCategoryList()
        {
            var result = _newsCategoryService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
