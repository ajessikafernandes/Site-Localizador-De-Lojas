using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LojasCRUD.Models;

namespace LojasCRUD.Pages.Lojas
{
    public class DeleteModel : PageModel
    {
        private readonly LojasCRUD.Models.LojaContext _context;

        public DeleteModel(LojasCRUD.Models.LojaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Loja Loja { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Loja = await _context.Lojas.FirstOrDefaultAsync(m => m.Id == id);

            if (Loja == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Loja = await _context.Lojas.FindAsync(id);

            if (Loja != null)
            {
                _context.Lojas.Remove(Loja);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
