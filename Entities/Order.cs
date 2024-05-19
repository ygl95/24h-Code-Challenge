using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _24h_Code_Challenge.Entities;

public partial class Order
{
    [Key]
    public long OrderId { get; set; }

    public string Date { get; set; }

    public string Time { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
