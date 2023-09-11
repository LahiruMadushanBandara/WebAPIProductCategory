using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIProductCategory.Models;
using WebAPIProductCategory.Service.DTO;

namespace WebAPIProductCategory.Service
{
    public class ProductService : IProductService
    {
        private readonly ProductDbContext _context;

        public ProductService()
        {
        }

        public ProductService(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDto>> GetAllProducts()
        {
            return await _context.Products
                .Select(x => new ProductDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Category = _context.Categories.Where(c => c.Id == x.Id)!.FirstOrDefault()!.Name 
                })
                .ToListAsync();
        }

    }
}
