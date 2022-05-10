using Microsoft.EntityFrameworkCore;
using Food_Dash.Models;

namespace Food_Dash.Data
{
    public class MenuContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }

        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().ToTable("Menu");
        }
    }
}
