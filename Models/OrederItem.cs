
namespace MVCApp.Models;

public class OrederItem
{
    public int ItemId { get; set; }
    public int OrderId { get; set; }
    public int Product { get; set; }
    public float PriceAtTime { get; set; }
    public int Quantity { get; set; }


}