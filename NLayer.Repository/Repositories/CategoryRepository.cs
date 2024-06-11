using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Core.Repositories;

namespace NLayer.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetSingleCategoryByIdWithProductAsync(int categoryId)
        {
            var category = await _context.Categories
                .Include(x => x.Products)
                .Where(x => x.Id == categoryId)
                .SingleOrDefaultAsync();

            return category ?? throw new Exception("Kategori Id'si bulunamadı.");
        }
    }
}
