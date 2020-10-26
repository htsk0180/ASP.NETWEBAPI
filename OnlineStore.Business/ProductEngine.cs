using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Business.Contracts;
using OnlineStore.Core.Common.Contracts.RequestMessages;
using OnlineStore.Core.Common.Contracts.ResponseMessages;
using OnlineStore.Data.Contracts;
using OnlineStore.Data.Entities;

namespace OnlineStore.Business
{
    public class ProductEngine : BusinessEngineBase, IProductEngine
    {
        private readonly IProductRepository _productRepository;

        public ProductEngine(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        #region IProductEngine Members
        public Task<ProductResponse> GetAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var product = await _productRepository.GetAsync(id);

                return Mapper.Map<ProductResponse>(product);
            });
        }

        public Task<ProductResponse> CreateAsync(ProductCreateRequest productCreateRequest)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var product = Mapper.Map<Product>(productCreateRequest);

                _productRepository.Add(product);

                await _productRepository.SaveChangeAsync();

                return Mapper.Map<ProductResponse>(product);
            });
        }

        public Task<ProductResponse> UpdateAsync(ProductUpdateRequest productUpdateRequest)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var product = Mapper.Map<Product>(productUpdateRequest);

                _productRepository.Update(product);

                await _productRepository.SaveChangeAsync();

                return Mapper.Map<ProductResponse>(product);
            });
        }

        public Task DeleteAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                await _productRepository.Delete(id);

                await _productRepository.SaveChangeAsync();
            });
        }

        public async Task<List<ProductResponse>> SearchAsync(ProductSearchRequest productSearchRequest)
        {
            return await ExecuteWithExceptionHandledOperation(async () =>
            {
                if (productSearchRequest.Take == 0)
                {
                    productSearchRequest.Take = ConfigurationHelper.DefaultProductListCount;
                }

                var searchQuery = _productRepository.GetAll(productSearchRequest.Skip, productSearchRequest.Take);

                if (!string.IsNullOrEmpty(productSearchRequest.ProductName))
                {
                    searchQuery = searchQuery.Where(p => p.Name.Contains(productSearchRequest.ProductName));
                }

                if (productSearchRequest.MinPrice != null)
                {
                    searchQuery = searchQuery.Where(p => p.Price >= productSearchRequest.MinPrice.Value);
                }

                if (productSearchRequest.MaxPrice != null)
                {
                    searchQuery = searchQuery.Where(p => p.Price >= productSearchRequest.MaxPrice.Value);
                }
                var aaa = searchQuery.ToList();
                return Mapper.Map<List<ProductResponse>>(await searchQuery.ToListAsync());
            });
        }
        #endregion
    }
}
