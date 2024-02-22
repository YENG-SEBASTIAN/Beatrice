using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aspCake.Models;
using aspCake.Data.DTOs;

namespace aspCake.Data.Service.Products
{
    public class ProductServices : IProductService
    {
        private readonly BcakesContext _dbContext;

        public ProductServices(BcakesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> InsertData(ProductDTO productDTO){
            var result = new aspCake.Models.Product{
                Name = productDTO.Name,
                Price = productDTO.Price
            };

            await _dbContext.Products.AddAsync(result);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteData(int id){
            var product = await _dbContext.Products.FindAsync(id);
            if(product == null){
                return false;
            }

            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<ProductDTO> GetDataAsync(int id){
            var product = await _dbContext.Products.FindAsync(id);
            if(product == null){
                return new ProductDTO();
            }

            var productDTO = new ProductDTO{
                Name = product.Name,
                Price = product.Price
            };

            return productDTO;
        }


        public async Task<List<ProductDTO>> GetAllDataAsync()
        {
            var products = await _dbContext.Products.ToListAsync();
            var productDTO = products.Select(x => new ProductDTO
            {
                ProductId = x.ProductId,
                Name = x.Name,
                Price = x.Price,
            }).ToList();

            return productDTO;
        }

        public async Task<bool> UpdateData(ProductDTO productDTO, int id){
            var product = await _dbContext.Products.FindAsync(id);
            if(product == null){
                return false;
            }

            product.Name = productDTO.Name;
            product.Price = productDTO.Price;

            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}