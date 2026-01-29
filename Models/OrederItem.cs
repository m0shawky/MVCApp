
namespace MVCApp.Models;

public class OrederItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public float PriceAtTime { get; set; }
    public int Quantity { get; set; }

   // public ICollection<Product> products {get; set;} = new List<Product> ();
    public Product Product  {get; set;}

    public Order Order  {get; set;}


}