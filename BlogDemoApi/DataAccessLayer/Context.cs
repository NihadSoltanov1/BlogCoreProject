using Microsoft.EntityFrameworkCore;

namespace BlogDemoApi.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=NIHAD; database=DemoBlogApiDB; integrated security=true;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
