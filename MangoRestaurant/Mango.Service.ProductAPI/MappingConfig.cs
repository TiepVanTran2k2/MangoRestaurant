using AutoMapper;
using Mango.Service.ProductAPI.Model;
using Mango.Service.ProductAPI.Repository.Dto;
using System.Net.NetworkInformation;

namespace Mango.Service.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
