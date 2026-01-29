namespace MVCApp.Models;

using MVCApp.Data;
public class Order
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public OrderStatus Orderstatus { get; set; }
    public DateTime OrderDate { get; set; }

    public ICollection<OrederItem> Items {get; set;}= new List<OrederItem> ();

    public User User {get; set;} 

}
