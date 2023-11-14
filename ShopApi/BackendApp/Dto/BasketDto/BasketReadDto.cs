using BackendApp.Models;

namespace BackendApp.Dto.BasketDto
{
    public class BasketReadDto
    {
        public int Id { get; set; }
        public int PublicUserId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
