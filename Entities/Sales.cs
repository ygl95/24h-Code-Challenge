using System.ComponentModel.DataAnnotations;

namespace _24h_Code_Challenge.Entities
{
    public class Sales
    {
        [Key]
        public long OrderDetailsId { get; set; }

        public long OrderId { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public string PizzaId { get; set; }

        public short Quantity { get; set; }

        public string PizzaTypeId { get; set; }

        public string Size { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Ingredients { get; set; }

        public string DayOfWeek { get; set; }
    }
}
