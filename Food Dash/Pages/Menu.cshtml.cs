using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Food_Dash.Models;
using Food_Dash.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Food_Dash.Pages
{
    public class MenuModel : PageModel
    {
        private readonly MenuContext _context;
        public List<Menu> Menus { get; set; }
        public MenuModel(MenuContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync()
        {
            Menus = await _context.Menus.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Menu Menu = await _context.Menus.FindAsync(id);

            if (Menu != null)
            {
                _context.Menus.Remove(Menu);
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Menu");
        }
    }
}
