using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SystemKontrahentow1.Data;
using SystemKontrahentow1.Models;

namespace SystemKontrahentow1.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly SystemKontrahentow1.Data.SystemKontrahentow1Context _context;

        public CreateModel(SystemKontrahentow1.Data.SystemKontrahentow1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || _context.Customer == null || Customer == null)
            {
                return Page();
            }
            else
            {
                _context.Customer.Add(Customer);
                _context.SaveChanges();

                return RedirectToPage("./Index");
            }
        }

    }
}
