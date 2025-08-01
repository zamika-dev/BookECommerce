namespace SampleStore.Services.ShoppingCarts
{
    public class CartCalculationDto
    {
        public List<ShoppingCartItemDto> shoppingCartItems =[];
        public double OrderTotal { get; set; }
        public double PostPrice { get; set; }
        public double Discount { get; set; }

        public double TotalPrice
        {
            get
            {
                return (OrderTotal - Discount) + PostPrice;
            }
        }
    }
}
