using AutoMapper;
using CodePulse.API.Core.Entities;
using CodePulse.API.Core.Interfaces;
using CodePulse.API.Dtos;
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
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequestDto createCategoryRequestDto)
        {
            var categoryDomain = _mapper.Map<Category>(createCategoryRequestDto);

            var category = await _categoryRepository.Post(categoryDomain);

            return Ok(category);

        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories([FromQuery] int Id)
        {
            var categories = await _categoryRepository.Get();

            var categoryToDisplay = _mapper.Map<List<CategoryToDisplayDto>>(categories);

            return Ok(categoryToDisplay);

        }
        [HttpGet]
        [Route("{id:long}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] long id)
        {
            var existingCategory = await _categoryRepository.GetById(id);

            if (existingCategory == null)

            { return NotFound(); }


            var categoryToDisplay = _mapper.Map<CategoryToDisplayDto>(existingCategory);

            return Ok(categoryToDisplay);
        }

        [HttpPut]
        [Route("{id:long}")]
        public async Task<IActionResult> Update([FromRoute] long id, [FromBody] CategoryToUpdateDto categoryToUpdate)
        {
            //convert do to domain model

            var updateCategory = await _categoryRepository.UpdateCategory(id, categoryToUpdate);

            if (updateCategory==null)
            {
                return NotFound();

            }
           
            return Ok(updateCategory);

        }

        [HttpDelete]
        [Route("{id:long}")]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            var category = await _categoryRepository.Delete(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);


        }
    }
}
