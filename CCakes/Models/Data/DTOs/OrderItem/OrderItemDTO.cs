using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCakes.Models.Data.DTOs.OrderItem
{
    public class OrderItemDTO
    {
        public int OrderItemId { get; set; }

        public int? ProductId { get; set; }

        public int? OrderId { get; set; }

        public int? Quantity { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }       
    }
}