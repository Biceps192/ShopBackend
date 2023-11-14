using BackendApp.Models;

namespace BackendApp.Dto.BasketDto
{
    public class BasketUpdateDto
    {
        public int ProductBasketId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
