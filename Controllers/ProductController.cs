using Microsoft.AspNetCore.Mvc;
using ProductApi.Data;
using ProductApi.Models;
using ProductApi.DTOs;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductDto dto)
        {
            var product = new Product
            {
                ProductName = dto.ProductName,
                CategoryId = dto.CategoryId,
                MRP = dto.MRP,
                SP = dto.SP,
                CP = dto.CP,
                Classification = dto.Classification,
                Size = dto.Size
            };
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, ProductDto dto)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound($"Product not found with this {id}");
            }
            product.ProductName = dto.ProductName;
            product.CategoryId = dto.CategoryId;
            product.MRP = dto.MRP;
            product.SP = dto.SP;
            product.CP = dto.CP;
            product.Classification = dto.Classification;
            product.Size = dto.Size;
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id, Product DeletedProduct)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound($"Product not Found with this {id}");
            }
            _context.Products.Remove(product);
            _context.SaveChanges(true);
            return Ok("Product deleted successfully");
        }
        
    }
}