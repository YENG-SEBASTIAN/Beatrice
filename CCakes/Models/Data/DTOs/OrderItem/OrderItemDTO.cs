namespace CCakes.Models.Data.DTOs.OrderItem
{
    public class OrderItemDTO
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } 
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        // Additional properties if needed

        public OrderItemDTO(int orderItemId, int productId, string productName, decimal productPrice, int quantity, decimal totalPrice)
        {
            OrderItemId = orderItemId;
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }
    }
}
