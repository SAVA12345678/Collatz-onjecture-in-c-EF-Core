using EfCore;
using Microsoft.EntityFrameworkCore;

public class AddDb : DbContext
{
    public DbSet<CollatzSys> CollatzSys { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlite("data Source = CollatzSys.db");
    }
}