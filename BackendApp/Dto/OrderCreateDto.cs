using BackendApp.Models;

namespace BackendApp.Dto
{
    public class OrderCreateDto
    {
        public DateTime OrderDate { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
        public int PublicUserId { get; set; }
    }
}
