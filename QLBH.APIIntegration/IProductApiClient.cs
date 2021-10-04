using QLBH.ViewModels.Catalog.Products;
using QLBH.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.APIIntegration
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);
        Task<bool> CreateProduct(ProductCreateRequest request);
        Task<bool> UpdateProduct(ProductUpdateRequest request);
        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);
        Task<List<ProductVm>> GetFeaturedProducts(string languageId, int take);
        Task<List<ProductVm>> GetLatestProducts(string languageId, int take);
        Task<ProductVm> GetById(int id, string languageId);
        Task<bool> DeleteProduct(int id);
    }
}
