using BookStore.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetCategoryWithBooks(int categoryId)
        {
            return Ok(await _service.GetCategoryWithBooks(categoryId));
        }
    }
}
