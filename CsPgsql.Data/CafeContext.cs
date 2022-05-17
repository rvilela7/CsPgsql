using CsPgsql.Data.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CsPgsql.Data;

public class CafeContext : DbContext
{
    public DbSet<Menu> menu { get; set; }

    public CafeContext(DbContextOptions<CafeContext> options)
        : base(options)
    {
    }
}
