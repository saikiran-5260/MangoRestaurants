using AutoMapper;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.DTO;

namespace Mango.Services.ProductAPI
{
    public class MapperConfig
    {
        public static MapperConfiguration RegisterMapper()
        {
            var mapper = new  MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product,ProductDto>();
            });
            return mapper;
        }
    }
}
