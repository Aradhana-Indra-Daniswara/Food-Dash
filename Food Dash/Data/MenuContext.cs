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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().ToTable("Menu");
        }
    }
}
