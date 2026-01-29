
namespace MVCApp.Models;

public class Product
{
    public int ProductId { get; set; }
    public required string ProductName { get; set; }
    public float ProductPrice { get; set; }

    public int CategoryId { get; set; }
    public int Stock { get; set; }

    public Category Category  {get; set;}

    public ICollection<OrederItem> Items {get; set;} = new List<OrederItem>();


}