using BackendApp.Models;

namespace BackendApp.Dto
{
    public class ProductReadDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
