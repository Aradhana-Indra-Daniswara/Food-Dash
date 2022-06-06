using Microsoft.EntityFrameworkCore;
using Food_Dash.Models;

namespace Food_Dash.Data
{
    public class MenuContext : DbContext
    {

        public MenuContext(DbContextOptions<MenuContext> options)
            : base(options)
        {
        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLink> OrderLinks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().ToTable("Menu");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderLink>().ToTable("OrderLink");
        }
    }
}
