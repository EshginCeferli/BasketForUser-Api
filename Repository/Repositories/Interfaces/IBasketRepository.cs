﻿using Domain.Entities;


namespace Repository.Repositories.Interfaces
{
    public interface IBasketRepository : IRepository<Basket>
    {
        Task AddBasketAsync(int id);
       Task<List<BasketProduct>> GetBasketProducts(); 
    }
}
