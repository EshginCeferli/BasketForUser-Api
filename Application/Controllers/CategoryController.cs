using Microsoft.AspNetCore.Mvc;
using Service.Services.Interfaces;

namespace Application.Controllers
{
    public class CategoryController : AppController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAllAsync();
            return Ok(result);
        }

    }
}
