using CodePulse.API.Core.Entities;
using CodePulse.API.Core.Interfaces;
using CodePulse.API.Dtos;
using CodePulse.API.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Infrastructure.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Category>> Get()
        {
            var categories = await _dbContext.Categories.ToListAsync();

            return categories;
        }

        public async Task<Category>? GetById(long id)
        {
            var category = await _dbContext.Categories.FirstOrDefaultAsync(c=> c.Id == id);

            return category;
        }

        public async Task<Category> Post(Category category)
        {
            var cat = await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category>? UpdateCategory(long id, CategoryToUpdateDto category)
        {


            var categoryToUpdate = await _dbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);

            if (categoryToUpdate == null)
            {
                return null;
            }
            categoryToUpdate.Name= category.Name;
            categoryToUpdate.UrlHandle= category.UrlHandle;

            await _dbContext.SaveChangesAsync();

            return categoryToUpdate;
        }
    }
}
