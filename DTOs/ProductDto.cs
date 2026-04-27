using System.ComponentModel.DataAnnotations;

namespace ProductApi.DTOs
{
    public class ProductDto
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Range(1, 10000)]
        public decimal MRP { get; set; }
        [Range(1, 10000)]
        public decimal SP { get; set; }
        [Range(1, 10000)]
        public decimal CP { get; set; }
        [Required]
        public string Classification { get; set; }
        public string Size { get; set; }
    }
}