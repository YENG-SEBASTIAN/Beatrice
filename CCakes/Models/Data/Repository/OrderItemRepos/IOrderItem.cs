using CCakes.Models.Data.DTOs.OrderItem;


namespace CCakes.Models.Data.Repository.OrderItemRepos
{
    public interface IOrderItem
    {
        Tasks<bool> AddOrderItemAsync(AddOrderItemDTO model);
        Tasks<bool> UpdateOrderItemAsync(AddOrderItemDTO model, int id);
        Task<List<OrderItemDTO>> GetOrderItemAsync();
        Task<OrderItemDTO> GetOrderItemByIdAsync(int id);
        Task<bool> DeleteOrderItemAsync(int id);
    }
}