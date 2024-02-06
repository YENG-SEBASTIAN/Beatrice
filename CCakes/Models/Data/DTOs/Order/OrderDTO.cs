using CCakes.Models;
namespace CCakes.Models.Data.DTOs.Order;
public class OrderDTO
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

}