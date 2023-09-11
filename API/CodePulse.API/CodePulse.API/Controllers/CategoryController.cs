using AutoMapper;
using CodePulse.API.Core.Entities;
using CodePulse.API.Core.Interfaces;
using CodePulse.API.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto createCategoryRequestDto)
        {
            var categoryDomain = _mapper.Map<Category>(createCategoryRequestDto);

            var category = await _categoryRepository.Post(categoryDomain);

            return Ok(category);

        }

    }
}
