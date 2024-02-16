using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspCake.Data.DTOs;

namespace aspCake.Data.DTOs
{
    public class OrderItemDTO
    {
        public int OrderItemId { get; set; }

        public int? ProductId { get; set; }

        public int? OrderId { get; set; }

        public int? Quantity { get; set; }

        public virtual OrderDTO Order { get; set; }

        public virtual ProductDTO Product { get; set; } 
    }
}