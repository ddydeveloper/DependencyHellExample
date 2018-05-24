using System;
using AutoMapper;
using dto;
using moduleB;

namespace ModuleBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Serialize();
            MapperConfig.Configure();
            Map();

            Console.ReadKey();
        }

        static void Serialize()
        {
            var serializerB = new moduleB.Serializer();

            var value = serializerB.Serialize(25);
            var result = serializerB.Deserialize(value);
            
            Console.WriteLine(result);
        }

        static void Map()
        {
            var dto1 = new Dto1 {Id = 1, Name = "Dto", Created = DateTime.Now};
            var dto2 = Mapper.Map<Dto2>(dto1);
            
            Console.WriteLine($"{dto2.Id}, {dto2.Name}, {dto2.Created}");
        }
    }
}