using System.Linq;
using System;
using Food_Dash.Models;

namespace Food_Dash.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MenuContext context)
        {
            context.Database.EnsureCreated();

            if (context.Menus.Any())
            {
                return;  
            }

            var Continents = new Menu[]
            {
                new Menu{Name="Nasi Goreng", Price=20000},
                new Menu{Name="Bakso Polos", Price=12000},
                new Menu{Name="Bakso Urat", Price=15000},
                new Menu{Name="Nasi Bakar", Price=24000},
                new Menu{Name="Es Teh Manis", Price=8000},
                new Menu{Name="Teh Manis Panas", Price=7000},
                new Menu{Name="Kucing", Price=99999},
            };

            foreach (Menu m in Continents)
            {
                context.Menus.Add(m);
            }
            context.SaveChanges();
        }
    }
}
