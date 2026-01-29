using MVCApp.Data;

namespace MVCApp.Models;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public UserRoles UserRole { get; set; }

    public int UserPhone { get; set; }

    public  string UserMail { get; set; }
    public  string UserHashPassword { get; set; }

    public ICollection<Order> Orders {get; set;} = new List<Order>();

}