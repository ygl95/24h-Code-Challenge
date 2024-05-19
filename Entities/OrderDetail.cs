using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _24h_Code_Challenge.Entities;

public partial class OrderDetail
{
    [Key]
    public long OrderDetailsId { get; set; }

    public long OrderId { get; set; }

    public string PizzaId { get; set; } = null!;

    public short Quantity { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Pizza Pizza { get; set; } = null!;
}
