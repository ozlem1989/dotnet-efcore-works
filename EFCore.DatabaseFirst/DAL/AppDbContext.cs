using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCore.DatabaseFirst.DAL
{
    public class AppDbContext : DbContext
    { 
        public DbSet<Product> Products { get; set; }

        // 1. yol :  to clarify which database we will use. 
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("DB"); 
        //}

        public AppDbContext()
        {
            
        }

        // 2.yol: 
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        //}

        // 3.yol
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlCon")!); 
        }
    }
}
