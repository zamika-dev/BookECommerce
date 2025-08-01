namespace SampleStore.Web.Models.Cart
{
    public class CheckoutAddressViewModel
    {
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
