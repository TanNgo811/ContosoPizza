namespace ECommerce.Models;

public class OrderItem
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Subtotal { get; set; }
    
    public virtual Order Order { get; set; } = null!;
    public virtual Product Product { get; set; } = null!;
}
