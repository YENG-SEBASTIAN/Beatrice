using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspCake.Data.DTOs;

namespace aspCake.Data.DTOs
{
    public class OrderDTO
    {
        public int OrderId { get; set; }

        public int? CustomerId { get; set; }

        public DateTime? OrderDate { get; set; }

        public virtual CustomerDTO Customer { get; set; }

        public virtual ICollection<OrderItemDTO> OrderItems { get; set; } = new List<OrderItemDTO>();       
    }
}