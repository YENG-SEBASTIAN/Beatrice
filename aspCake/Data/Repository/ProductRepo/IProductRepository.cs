using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspCake.Models;
using aspCake.Data.Repository.BaseRepo;

namespace aspCake.Data.Repository.ProductRepo
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        
    }
}