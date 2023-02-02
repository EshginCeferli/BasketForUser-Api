using Microsoft.AspNetCore.Mvc;
using Service.Services.DTOs.Product;
using Service.Services;
using Service.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Application.Controllers
{
    public class BasketController :AppController
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpPost]
        public async Task<IActionResult> AddBasket([Required][FromQuery]int id)
        {
            await _basketService.AddBasketAsync(id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetBasketProducts()
        {          
            return Ok( await _basketService.GetBasketProducts());
        }
    }
}
