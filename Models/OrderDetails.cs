namespace _24h_Code_Challenge.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PizzaId { get; set; }
        public int Quantity { get; set; }
    }
}
