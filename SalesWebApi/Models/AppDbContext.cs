using Microsoft.EntityFrameworkCore;

namespace SalesWebApi.Models {

    public class AppDbContext : DbContext {

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) {
        }
    }
}
