using Microsoft.EntityFrameworkCore;

namespace BlogDemooApi.DataLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=NIHAD; database=CoreBlogProjectAPIDB; integrated security=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
