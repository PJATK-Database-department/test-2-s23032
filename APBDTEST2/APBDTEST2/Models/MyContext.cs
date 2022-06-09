using Microsoft.EntityFrameworkCore;
using APBDTEST2.Configurations;

namespace APBDTEST2.Models
{
    public class MyContext : DbContext
    {
        public MyContext () { }
        public MyContext (DbContextOptions<MyContext> options) : base (options) { }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientOrder> ClientOrders { get; set; }
        public virtual DbSet<Confectionery> Confectioneries { get; set; }
        public virtual DbSet<Confectionery_ClientOrder> ConfOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfig());
            modelBuilder.ApplyConfiguration(new ClientOrderConfig());
            modelBuilder.ApplyConfiguration(new ConfectioneryConfig());
            modelBuilder.ApplyConfiguration(new Confectionery_ClientOrderConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
        }
    }
}
