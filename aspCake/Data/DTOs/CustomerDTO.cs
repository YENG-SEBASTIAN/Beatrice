using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspCake.Data.DTOs;

namespace aspCake.Data.DTOs
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public virtual ICollection<OrderDTO> Orders { get; set; } = new List<OrderDTO>(); 
    }
}