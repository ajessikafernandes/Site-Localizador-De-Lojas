using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LojasCRUD.Models;

namespace LojasCRUD.Pages.Lojas
{
    public class EditModel : PageModel
    {
        private readonly LojasCRUD.Models.LojaContext _context;

        public EditModel(LojasCRUD.Models.LojaContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Loja).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LojaExists(Loja.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LojaExists(int id)
        {
            return _context.Lojas.Any(e => e.Id == id);
        }
    }
}
