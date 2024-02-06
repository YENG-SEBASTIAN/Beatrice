using CCakes.Models.Data.DTOs.Order;

namespace CCakes.Models.Data.Repository.OrderRepo
{
    public interface IOrder
    {
        Task<bool> AddOrderAsync(AddOrderDTO model);
        Task<bool> UpdateOrderAsync(AddOrderDTO model, int id);
        Task<List<OrderDTO>> GetMOrderAsync();
        Task<OrderDTO> GetOrderByIdAsync(int id);
        Task<bool> DeleteOrderAsync(int id);
    }
}