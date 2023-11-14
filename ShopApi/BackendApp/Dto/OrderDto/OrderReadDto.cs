using BackendApp.Models;

namespace BackendApp.Dto.OrderDto
{
    public class OrderReadDto
    {
        public int Id { get; set; }
        public int PublicUserId { get; set; }
        public int BasketId { get; set; }
        public decimal Price { get; set; }
    }
}
