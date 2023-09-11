using Microsoft.AspNetCore.Mvc;
using WebAPIProductCategory.Controllers;
using WebAPIProductCategory.Service;

namespace UnitTestProject_Products
{
    public class UnitTestProduct
    {
        ProductController _productController;
        IProductService _productService;

        public UnitTestProduct()
        {
            _productService = new ProductService();
            _productController = new ProductController(_productService);
        }

        [Fact]
        public void GetAllProductTest()
        {
            var result = _productController.GetAllProducts();
            

            Assert.NotNull(result);
        }
    }
}