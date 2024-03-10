using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SystemKontrahentow1.Data;
using SystemKontrahentow1.Models;

namespace SystemKontrahentow1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        private readonly SystemKontrahentow1.Data.SystemKontrahentow1Context _context;

        public IndexModel(SystemKontrahentow1.Data.SystemKontrahentow1Context context)
        {
            _context = context;
        }


    }
}