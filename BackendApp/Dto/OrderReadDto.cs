using BackendApp.Models;

namespace BackendApp.Dto
{
    public class OrderReadDto
    {
        public int Id { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
        public int PublicUserId { get; set; }
    }
}
