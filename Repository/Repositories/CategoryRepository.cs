using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {

        private readonly AppDbContext _context;
        private readonly DbSet<Category> _entities;
        public CategoryRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _entities = _context.Set<Category>();
        }

        public async Task<List<Category>> GetAllCategories()
        {
            var result = await _entities
                .Where(m => m.SoftDeleted == false)
                .Include(m => m.Products)
                .ToListAsync();
            return result;
        }
    }
}
