namespace BackendApp.Dto.OrderDto
{
    public class OrderReadDto
    {
        public int BasketId { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
