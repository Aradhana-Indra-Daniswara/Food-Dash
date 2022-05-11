using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Food_Dash.Models;
using Food_Dash.Data;
using System.Threading.Tasks;
using System;

namespace Food_Dash.Pages
{
    public class EditMenuModel : PageModel
    {
        private readonly MenuContext _context;

        [BindProperty]
        public Menu Menu { get; set; }
        public EditMenuModel(MenuContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            Menu = await _context.Menus.FindAsync(id);

            if (Menu == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            Menu.Name = id;
            _context.Attach(Menu).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("./Menu");
        }
    }
}
