using AutoMapper;
using CodePulse.API.Core.Entities;
using CodePulse.API.Dtos;

namespace CodePulse.API.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //source to destr
            CreateMap<CreateCategoryRequestDto, Category>().ReverseMap();
        }
    }
}
