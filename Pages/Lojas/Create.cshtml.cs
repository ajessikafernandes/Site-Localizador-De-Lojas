using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LojasCRUD.Models;

namespace LojasCRUD.Pages.Lojas
{
    public class CreateModel : PageModel
    {
        private readonly LojasCRUD.Models.LojaContext _context;

        public CreateModel(LojasCRUD.Models.LojaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Loja Loja { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lojas.Add(Loja);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}