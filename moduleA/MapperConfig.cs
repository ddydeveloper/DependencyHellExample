using AutoMapper;
using dto;

namespace moduleA
{
    public class MapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(config => { config.CreateMap<Dto1, Dto2>(); });
        }
    }
}