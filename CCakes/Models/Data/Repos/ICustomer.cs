using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCakes.Models.Data.Repos
{
    public interface ICustomer
    {
        int CustomerId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
    }
}