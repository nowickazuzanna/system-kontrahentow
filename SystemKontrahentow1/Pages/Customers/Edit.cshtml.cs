using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SystemKontrahentow1.Data;
using SystemKontrahentow1.Models;

namespace SystemKontrahentow1.Pages.Customers
{
    public class EditModel : PageModel
    {
        private readonly SystemKontrahentow1.Data.SystemKontrahentow1Context _context;

        public EditModel(SystemKontrahentow1.Data.SystemKontrahentow1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }

            var customer =  await _context.Customer.FirstOrDefaultAsync(m => m.Id == id);

            if (customer == null)
            {
                return NotFound();
            }
            Customer = customer;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Update(Customer);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");

        }

        
    }
}
