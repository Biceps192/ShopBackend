using BackendApp.Data;
using BackendApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendApp.Dto.OrderDto
{
    public class OrderCreateDto
    {
        public int BasketId { get; set; }
        public string Address { get; set; }
    }
}
