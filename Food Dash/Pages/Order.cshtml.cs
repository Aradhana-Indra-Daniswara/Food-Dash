using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Food_Dash.Models;
using Food_Dash.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Food_Dash.Pages
{
    public class OrderModel : PageModel
    {
        private readonly MenuContext _context;

        public OrderModel(MenuContext context)
        {
            _context = context;
        }

        public List<Order> Orders { get; set; }
        public List<OrderLink> OrderLinks { get; set; }

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders.ToListAsync();
            OrderLinks = await _context.OrderLinks.ToListAsync();
        }
    }
}
