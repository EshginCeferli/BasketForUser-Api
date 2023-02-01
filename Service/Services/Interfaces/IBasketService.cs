using Domain.Entities;
using Service.Services.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IBasketService
    {
        Task AddBasketAsync(int id);
        Task<List<BasketProduct>> GetBasketProducts();
    }
}
