using CodePulse.API.Core.Entities;
using CodePulse.API.Core.Interfaces;
using CodePulse.API.Infrastructure.Data;

namespace CodePulse.API.Infrastructure.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Category> Post(Category category)
        {
            var cat = await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return category;
        }
    }
}
