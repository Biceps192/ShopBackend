namespace BackendApp.Dto.BasketDto
{
    public class ProductBasketDeleteDto
    {
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
