using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LojasCRUD.Pages
{
    public class AboutModel : PageModel
    {
        private const string V = "Teste";

        public string Message { get; set; }

        public void OnGet()
        {
            Message = V;
        }
    }
}
