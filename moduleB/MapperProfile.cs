using AutoMapper;
using dto;

namespace moduleB
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Dto1, Dto2>();
        }
    }
}