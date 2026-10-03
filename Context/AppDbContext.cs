using Microsoft.EntityFrameworkCore;
using auth30.Models;
namespace auth30.Context;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<User>User {get;set;}
}