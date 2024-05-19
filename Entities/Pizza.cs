using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _24h_Code_Challenge.Entities;

public partial class Pizza
{
    [Key]
    public string PizzaId { get; set; } = null!;

    public string PizzaTypeId { get; set; } = null!;

    public string Size { get; set; } = null!;

    public double Price { get; set; }
    [JsonIgnore]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    [JsonIgnore]
    public virtual PizzaType PizzaType { get; set; } = null!;
}
