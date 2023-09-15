using CodePulse.API.Core.Entities;
using CodePulse.API.Dtos;

namespace CodePulse.API.Core.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> Post(Category category);
        Task<List<Category>>? Get();
        Task<Category>? GetById(long id);
        Task<Category>? UpdateCategory(long id,CategoryToUpdateDto category);
    }
}
