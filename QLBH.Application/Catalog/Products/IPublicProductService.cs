using QLBH.ViewModels.Catalog.Products;
using QLBH.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLBH.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
