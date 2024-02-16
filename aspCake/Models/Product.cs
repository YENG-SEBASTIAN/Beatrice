using System;
using System.Collections.Generic;

namespace aspCake.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
