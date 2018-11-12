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
    public class MapModel : PageModel
    {
        private readonly LojasCRUD.Models.LojaContext _context;

        public MapModel(LojasCRUD.Models.LojaContext context)
        {
            _context = context;
        }

        public IList<Loja> Loja { get;set; }

        public async Task OnGetAsync()
        {
            Loja = await _context.Lojas.ToListAsync();
        }
    }
}
