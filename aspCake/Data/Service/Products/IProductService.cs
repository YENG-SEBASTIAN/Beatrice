using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspCake.Data.Repository.ProductRepo;
using aspCake.Data.DTOs;

namespace aspCake.Data.Service.Products
{
    public interface IProductService
    {
        Task<bool> InsertData(ProductDTO productDTO);
        Task<bool> UpdateData(ProductDTO productDTO, int id);
        Task<List<ProductDTO>> GetAllDataAsync();
        Task<ProductDTO> GetDataAsync(int id);
        Task<bool> DeleteData(int id);
    }
}