using AutoMapper;
using OnlineStore.Core.Common.Contracts.RequestMessages;
using OnlineStore.Data.Entities;

namespace OnlineStore.Core.Mappings
{
    public class RequestMessagesToEntities
    {
        public static void Map(IMapperConfiguration mapperConfiguration)
        {
            mapperConfiguration.CreateMap<UserCreateRequest, User>();
            mapperConfiguration.CreateMap<UserUpdateRequest, User>();
            mapperConfiguration.CreateMap<CategoryCreateRequest, Category>();
            mapperConfiguration.CreateMap<CategoryUpdateRequest, Category>();
            mapperConfiguration.CreateMap<ProductCreateRequest, Product>();
            mapperConfiguration.CreateMap<ProductUpdateRequest, Product>();
        }
    }
}
