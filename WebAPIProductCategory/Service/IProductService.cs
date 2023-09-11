using WebAPIProductCategory.Models;
using WebAPIProductCategory.Service.DTO;

namespace WebAPIProductCategory.Service
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProducts();
    }
}
