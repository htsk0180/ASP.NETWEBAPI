using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineStore.Core.Common.Contracts;
using OnlineStore.Core.Common.Contracts.RequestMessages;
using OnlineStore.Core.Common.Contracts.ResponseMessages;

namespace OnlineStore.Business.Contracts
{
    public interface IProductEngine : IBusinessEngine
    {
        Task<ProductResponse> GetAsync(int id);
        Task<ProductResponse> CreateAsync(ProductCreateRequest productCreateRequest);
        Task<ProductResponse> UpdateAsync(ProductUpdateRequest productUpdateRequest);
        Task DeleteAsync(int id);
        Task<List<ProductResponse>> SearchAsync(ProductSearchRequest productSearchRequest);
    }
}
