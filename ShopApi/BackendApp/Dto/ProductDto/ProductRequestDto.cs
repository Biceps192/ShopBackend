using BackendApp.Models;

namespace BackendApp.Dto.ProductDto
{
    public class ProductPageResult
    {
        public IEnumerable<Product> Products { get; set; }
        public int TotalCount { get; set; }
    }
}
