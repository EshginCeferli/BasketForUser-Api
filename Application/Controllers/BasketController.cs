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
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            
            await _basketService.AddBasketAsync(id);
            return Ok();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetBasketProducts()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return Ok( await _basketService.GetBasketProducts());
        }
    }
}
