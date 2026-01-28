
namespace MVCApp.Models;

public class Category
{
    public int CategoryId { get; set; }
    public required string ProductName { get; set; }
    public float ProductPrice { get; set; }

    public int ProductCategory { get; set; }
    public int Stock { get; set; }


}