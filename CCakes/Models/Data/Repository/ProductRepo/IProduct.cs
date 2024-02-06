using CCakes.Models.Data.DTOs.Product;

namespace CCakes.Models.Data.Repository.ProductRepo
{
    public interface IProduct
    {
        Task<bool> AddProductAsync(AddProductDTO model);
        Task<bool> UpdateProductAsync(AddProductDTO model, int id);
        Task<List<ProductDTO>> GetMProductAsync();
        Task<ProductDTO> GetProductByIdAsync(int id);
        Task<bool> DeleteProductAsync(int id);
    }
}