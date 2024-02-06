using CCakes.Models.Data.DTOs.Product;

namespace CCakes.Models.Data.Repository.ProductRepos
{
    public interface IProduct
    {
        Tasks<bool> AddProductAsync(AddProductDTO model);
        Tasks<bool> UpdateProductAsync(AddProductDTO model, int id);
        Task<List<ProductDTO>> GetProductAsync();
        Task<ProductDTO> GetProductByIdAsync(int id);
        Task<bool> DeleteProductAsync(int id);
    }
}