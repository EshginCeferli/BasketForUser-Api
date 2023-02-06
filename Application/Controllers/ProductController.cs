using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Product;
using Service.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Application.Controllers
{
    public class ProductController : AppController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

      
        [HttpPost]
        [Authorize(Roles = "SuperAdmin , Admin")]
        public async Task<IActionResult> Create([FromBody] ProductCreateDto product)
        {
            await _productService.Createasync(product);
            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
          
            return Ok(await _productService.GetAllAsync());
        }


       
        [HttpDelete]
        [Authorize(Roles = "SuperAdmin , Admin")]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _productService.DeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin , Admin")]
        public async Task<IActionResult> SoftDelete([Required] int id)
        {
            try
            {
                await _productService.SoftDeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }

        }

        //[Authorize(Roles = "Member")]
        [HttpPut]        
        [Route("{id}")]
        [Authorize(Roles = "SuperAdmin , Admin")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, ProductUpdateDto product)
        {
            try
            {
                await _productService.UpdateAsync(id, product);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Search(string? search)
        {
            return Ok(await _productService.SearchAsync(search));
        }

        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            return Ok(await _productService.GetByIdAsync(id));
        }
    }
}
