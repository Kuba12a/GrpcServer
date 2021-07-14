using Microsoft.EntityFrameworkCore;

namespace testt.Model
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
    }
}
