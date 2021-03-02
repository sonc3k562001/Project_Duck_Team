using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginRegister.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginRegister.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Account account { get; set; }
        public void OnGet()
        {
            account = new Account();
        }
    }
}
