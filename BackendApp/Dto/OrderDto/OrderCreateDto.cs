using BackendApp.Data;
using BackendApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendApp.Dto.OrderDto
{
    public class OrderCreateDto
    {
        public DateTime OrderDate { get; set; }
        public int BasketId { get; set; }
        public int PublicUserId { get; set; }
        public decimal Price { get; set; }
    }
}
