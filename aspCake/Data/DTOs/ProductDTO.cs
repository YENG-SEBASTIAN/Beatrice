using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspCake.Data.DTOs;

namespace aspCake.Data.DTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal? Price { get; set; }

        public virtual ICollection<OrderItemDTO> OrderItems { get; set; } = new List<OrderItemDTO>();
    }
}