namespace MVCApp.Models;

using MVCApp.Data;
public class Order
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public OrderStatus Orderstatus { get; set; }
    public int OrderDate { get; set; }

}
