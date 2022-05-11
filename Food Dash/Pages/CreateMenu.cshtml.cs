using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Food_Dash.Models;
using Food_Dash.Data;
using System.Threading.Tasks;
using System;

namespace Food_Dash.Pages
{
    public class CreateMenuModel : PageModel
    {
        private readonly MenuContext _context;

        [BindProperty]
        public Menu Menu { get; set; }
        public CreateMenuModel(MenuContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            _context.Menus.Add(Menu);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Menu");
        }
    }
}
