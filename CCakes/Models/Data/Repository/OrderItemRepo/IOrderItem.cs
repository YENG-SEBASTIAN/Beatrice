using CCakes.Models.Data.DTOs.OrderItem;

namespace CCakes.Models.Data.Repository.OrderItemRepo
{
    public interface IOrderItem
    {
        Task<bool> AddOrderItemAsync(AddOrderItemDTO model);
        Task<bool> UpdateOrderItemAsync(AddOrderItemDTO model, int id);
        Task<List<OrderItemDTO>> GetMOrderItemAsync();
        Task<OrderItemDTO> GetOrderItemByIdAsync(int id);
        Task<bool> DeleteOrderItemAsync(int id);
    }
}