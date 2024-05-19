using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _24h_Code_Challenge.Entities;

public partial class PizzaType
{
    [Key]
    public string PizzaTypeId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Ingredients { get; set; } = null!;
    public virtual ICollection<Pizza> Pizzas { get; set; } = new List<Pizza>();
}
