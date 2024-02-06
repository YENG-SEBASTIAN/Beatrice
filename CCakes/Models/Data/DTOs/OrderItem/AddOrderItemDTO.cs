using CCakes.Models;

namespace CCakes.Models.Data.DTOs.OrderItem;

public class AddOrderItemDTO
{
    public int? ProductId { get; set; }

    public int? OrderId { get; set; }

    public int? Quantity { get; set; }

}