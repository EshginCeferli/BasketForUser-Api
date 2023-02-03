using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Product;
using Service.Services;
using Service.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Application.Controllers
{
    public class BasketController :AppController
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddBasket([Required][FromQuery]int id)
        {           
            
            await _basketService.AddBasketAsync(id);
            return Ok();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetBasketProducts()
        {       

            return Ok( await _basketService.GetBasketProductsAsync());
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteBasketProduct([Required][FromQuery] int id)
        {
            await _basketService.DeleteBasketAsync(id);
            return Ok();
        }

    }
}
