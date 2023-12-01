namespace BackendApp.Dto.BasketDto
{
    public class AddProductToBasketDto
    {
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
