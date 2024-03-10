using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SystemKontrahentow1.Data;
using SystemKontrahentow1.Models;

namespace SystemKontrahentow1.Pages
{
    public class CustomersModel : PageModel
    {
        private readonly SystemKontrahentow1.Data.SystemKontrahentow1Context _context;

        public CustomersModel(SystemKontrahentow1.Data.SystemKontrahentow1Context context)
        {
            _context = context;
        }

        public IList<Customer> Customers { get;set; } 
        public async Task OnGetAsync()
        {
            if (_context.Customer != null)
            {
                Customers = await _context.Customer.ToListAsync();
            }
        }

        


    }
}
