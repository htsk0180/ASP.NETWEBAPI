using AutoMapper;
using OnlineStore.Core.Common.Contracts.ResponseMessages;
using OnlineStore.Data.Entities;

namespace OnlineStore.Core.Mappings
{
    public class EntitiesToResponseMessages
    {
        public static void Map(IMapperConfiguration mapperConfiguration)
        {
            mapperConfiguration.CreateMap<User, UserResponse>();
            mapperConfiguration.CreateMap<Category, CategoryResponse>();
            mapperConfiguration.CreateMap<Product, ProductResponse>();
        }
    }
}
