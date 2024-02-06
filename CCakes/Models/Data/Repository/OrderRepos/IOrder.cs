using CCakes.Models.Data.DTOs.Orders;


namespace CCakes.Models.Data.Repository.OrderRepos
{
    public class IOrder
    {
        Tasks<bool> AddOrderAsync(AddOrderDTO model);
        Tasks<bool> UpdateOrderAsync(AddOrderDTO model, int id);
        Task<List<OrderDTO>> GetOrderAsync();
        Task<OrderDTO> GetOrderByIdAsync(int id);
        Task<bool> DeleteOrderAsync(int id);
    }
}