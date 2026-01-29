using Microsoft.EntityFrameworkCore;
using MVCApp.Models;
using MVCApp.Data;


namespace MVCApp.Data;

public class AppDbContext : DbContext
{
public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
{
}

    public DbSet<Product> Products{get; set;} 
    public DbSet<Order> Orders{get; set;} 
    public DbSet<Category> Categories{get; set;} 
    public DbSet<OrederItem> Items {get; set;} 
    public DbSet<User> Users{get; set;} 


}