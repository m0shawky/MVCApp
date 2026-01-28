
namespace MVCApp.Models;

public class Product
{
    public int ProductId { get; set; }
    public required string ProductName { get; set; }
    public float ProductPrice { get; set; }

    public int ProductCategory { get; set; }
    public int Stock { get; set; }


}