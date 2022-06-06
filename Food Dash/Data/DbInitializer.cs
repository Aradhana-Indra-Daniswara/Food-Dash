using Food_Dash.Models;
using System.Collections.Generic;
using System.Linq;

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

            var Menus = new Menu[]
            {
                new Menu{Name="Nasi Goreng", Price=20000},
                new Menu{Name="Bakso Polos", Price=12000},
                new Menu{Name="Bakso Urat", Price=15000},
                new Menu{Name="Nasi Bakar", Price=24000},
                new Menu{Name="Es Teh Manis", Price=8000},
                new Menu{Name="Teh Manis Panas", Price=7000},
            };

            foreach (Menu m in Menus)
            {
                context.Menus.Add(m);
            }
            context.SaveChanges();

            var Orders = new Order[]
            {
                new Order{
                    OrderId = "FD001",
                    CustomerName = "Aradhana Indra",
                },
                new Order{
                    OrderId = "FD002",
                    CustomerName = "Daniswara",
                },
            };

            foreach (Order o in Orders)
            {
                context.Orders.Add(o);
            }
            context.SaveChanges();

            var OrderLinks = new OrderLink[]
            {
                new OrderLink
                {
                    OrderLinkId = "1",
                    OrderId = "FD001",
                    Quantity = 2,
                    MenuName = "Nasi Goreng"
                },

                new OrderLink
                {
                    OrderLinkId = "2",
                    OrderId = "FD001",
                    Quantity = 1,
                    MenuName = "Nasi Bakar"
                },
                new OrderLink
                {
                    OrderLinkId = "3",
                    OrderId = "FD001",
                    Quantity = 1,
                    MenuName = "Es Teh Manis"
                },
                new OrderLink
                {
                    OrderLinkId = "4",
                    OrderId = "FD002",
                    Quantity = 1,
                    MenuName = "Teh Manis Panas"
                },
            };

            foreach (OrderLink o in OrderLinks)
            {
                context.OrderLinks.Add(o);
            }
            context.SaveChanges();
        }
    }
}
