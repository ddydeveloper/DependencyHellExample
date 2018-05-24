using AutoMapper;

namespace moduleB
{
    public class MapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<MapperProfile>();
            });

            Mapper.Configuration.AssertConfigurationIsValid();               
        }
    }
}