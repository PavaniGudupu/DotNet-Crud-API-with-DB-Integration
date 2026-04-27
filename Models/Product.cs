namespace ProductApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal MRP { get; set; }
        public decimal SP { get; set; }
        public decimal CP { get; set; }
        public string Classification { get; set; }
        public string Size { get; set; }
    }
}