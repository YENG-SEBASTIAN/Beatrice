using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCakes.Models.Data.DTOs.Customer;

public class AddCustomerDTO
{
    
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}