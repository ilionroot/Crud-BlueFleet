using Microsoft.EntityFrameworkCore;

namespace Crud_BlueFleet.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}

        public DbSet<Car> Car { get; set; }
    }
}
