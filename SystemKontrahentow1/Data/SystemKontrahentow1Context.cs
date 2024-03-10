using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SystemKontrahentow1.Models;

namespace SystemKontrahentow1.Data
{
    public class SystemKontrahentow1Context : DbContext
    {
        public SystemKontrahentow1Context (DbContextOptions<SystemKontrahentow1Context> options)
            : base(options)
        {
        }

        public DbSet<SystemKontrahentow1.Models.Customer> Customer { get; set; } = default!;
    }
}
