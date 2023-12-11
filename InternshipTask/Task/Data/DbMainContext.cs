using Microsoft.EntityFrameworkCore;

using TactaTask.Models;

namespace TactaTask.Data;

public class DBMainContext : DbContext
{
    public DBMainContext(DbContextOptions<DBMainContext> options) : base(options)
    {

    }
    public DbSet<Shopper> Shoppers { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ShoppingList> ShoppingList { get; set; }
    
}