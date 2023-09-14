using AutoMapper;
using CodePulse.API.Core.Entities;
using CodePulse.API.Dtos;

namespace CodePulse.API.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //source to destination
            CreateMap<CreateCategoryRequestDto, Category>().ReverseMap();
            CreateMap<Category, CategoryToDisplayDto>().ReverseMap();
        }
    }
}
