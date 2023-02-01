using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class BasketRepository : Repository<Basket>, IBasketRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Basket> _entities;
        private readonly IHttpContextAccessor _httpContextAccessor;



        public BasketRepository(AppDbContext context, IHttpContextAccessor httpContextAccessor) : base(context)
        {
            _context = context;
            _entities = _context.Set<Basket>();
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task AddBasketAsync(int id)
        {

            var user = _httpContextAccessor.HttpContext.User;

            if (user == null) throw new UnauthorizedAccessException();

            var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userId == null) throw new UnauthorizedAccessException();


            var basket = await _entities
                .Include(m => m.BasketProducts)
                .FirstOrDefaultAsync(m => m.AppUserId == userId);

            if (basket == null)
            {
                basket = new Basket
                {
                    AppUserId = userId
                };

                await _entities.AddAsync(basket);
                await _context.SaveChangesAsync();
            }


            var basketProduct = basket.BasketProducts
                .FirstOrDefault(bp => bp.BasketId == basket.Id);

            if (basketProduct != null)
            {
                basketProduct.Quantity++;
            }
            else
            {
                basketProduct = new BasketProduct
                {
                    BasketId = basket.Id,
                    ProductId = id,
                    Quantity = 1
                };
                basket.BasketProducts.Add(basketProduct);

            }
            _context.SaveChanges();
        }

        public async Task<List<BasketProduct>> GetBasketProducts()
        {
            var user = _httpContextAccessor.HttpContext.User;

            if (user == null) throw new UnauthorizedAccessException();

            //var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userId = "4c3af473-207b-4030-8431-0796f1286d6a";


            if (userId == null) throw new UnauthorizedAccessException();


            var basket = await _entities
                .Include(m => m.BasketProducts)
                .FirstOrDefaultAsync(m => m.AppUserId == userId);

            var basketProducts = basket.BasketProducts;

            return basketProducts;
        }
    }
}
