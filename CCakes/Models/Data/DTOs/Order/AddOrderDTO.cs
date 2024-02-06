using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCakes.Models.Data.DTOs.Order;

public class AddOrderDTO
{
    public int? CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public virtual Customer Customer { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
