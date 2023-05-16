namespace Checkout.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Country Country { get; set; }
        public Product Product { get; set; }
    }
}
