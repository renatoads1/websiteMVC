using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Weba2mvc.Models;

namespace Weba2mvc.Data
{
    public class Weba2mvcContext : DbContext
    {
        public Weba2mvcContext (DbContextOptions<Weba2mvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Saller> Saller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Product> Product { get; set; }


    }
}
