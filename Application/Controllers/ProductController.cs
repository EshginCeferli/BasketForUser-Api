using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Product;
using Service.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Application.Controllers
{
    public class ProductController : AppController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        //[Authorize(Roles ="Admin")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateDto product)
        {
            await _productService.Createasync(product);
            return Ok();
        }

   
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            //var id = User.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;


            return Ok(await _productService.GetAllAsync());
        }


        //[Authorize(Roles = "SuperAdmin")]
        [HttpDelete]
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
