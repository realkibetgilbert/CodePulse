using CodePulse.API.Core.Entities;

namespace CodePulse.API.Core.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> Post(Category category);
        Task<List<Category>> Get();
    }
}
