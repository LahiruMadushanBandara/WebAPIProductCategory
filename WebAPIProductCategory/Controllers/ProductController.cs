using Microsoft.AspNetCore.Mvc;
using WebAPIProductCategory.Service;
using WebAPIProductCategory.Service.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIProductCategory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAllProducts", Name = "GetAllProducts")]
        public async Task<List<ProductDto>> GetAllProducts()
        {
            try
            {
                return await _productService.GetAllProducts();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
