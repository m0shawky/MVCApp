using MVCApp.Data;

namespace MVCApp.Models;

public class User
{
    public int UserId { get; set; }
    public required string UserName { get; set; }
    public UserRoles UserRole { get; set; }

    public int UserPhone { get; set; }

    public required string UserMail { get; set; }
    public required string UserHashPassword { get; set; }

}