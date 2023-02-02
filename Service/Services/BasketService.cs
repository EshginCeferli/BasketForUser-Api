﻿using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.Services.DTOs.Basket;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _repo;
        private readonly IMapper _mapper;
        public BasketService(IBasketRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task AddBasketAsync(int id)
        {
            await _repo.AddBasketAsync(id);
        }

        public async Task<List<BasketProductListDto>> GetBasketProducts()
        {
            var basketProducts = await _repo.GetBasketProducts();
            return _mapper.Map<List<BasketProductListDto>>(basketProducts);
        }
    }
}
