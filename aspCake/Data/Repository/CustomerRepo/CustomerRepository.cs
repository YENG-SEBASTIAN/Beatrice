using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspCake.Models;
using aspCake.Data.Repository.BaseRepo;


namespace aspCake.Data.Repository.CustomerRepo
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(BcakesContext dbContext) : base(dbContext){
            
        }
    }
}