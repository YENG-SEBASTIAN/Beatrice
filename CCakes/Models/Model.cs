using System;
using System.Collections.Generic;
using System.Linq;

namespace CCakes.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        // Additional customer-related properties can be added
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        // Additional product-related properties can be added
    }

    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Quantity * Product.Price; // Calculated property
        // Additional order item-related properties can be added

        // Navigation property
        public Product Product { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public decimal TotalPrice => OrderItems.Sum(item => item.TotalPrice); // Calculated property
        // Additional order-related properties can be added

        // Navigation properties
        public Customer Customer { get; set; }
    }
}
