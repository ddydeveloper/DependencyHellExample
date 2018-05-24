using System;
using System.Reflection;
using AutoMapper;
using dto;
using moduleA;

namespace DependencyHellNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Serialize();
            ConfigAutomapper();
            Map();

            Console.ReadKey();
        }

        static void ConfigAutomapper()
        {
            moduleA.MapperConfig.Configure();
            moduleB.MapperConfig.Configure();
        }

        static void Serialize()
        {
            var serializerA = new moduleA.Serializer();
            var serializerB = new moduleB.Serializer();

            var value = serializerA.Serialize(25);
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