using CCakes.Models;

namespace CCakes.Models.Data.DTOs.OrderItem;

public class OrderItemDTO
{
    public int OrderItemId { get; set; }

    public int? ProductId { get; set; }

    public int? OrderId { get; set; }

    public int? Quantity { get; set; }

}