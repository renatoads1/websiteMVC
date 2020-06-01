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

        public DbSet<Weba2mvc.Models.Pessoas> Pessoas { get; set; }

        public DbSet<Weba2mvc.Models.Pesquisa> Pesquisa { get; set; }

        public DbSet<Weba2mvc.Models.Produtos> Produtos { get; set; }

        public DbSet<Weba2mvc.Models.Fornecedor> Fornecedor { get; set; }

        public DbSet<Weba2mvc.Models.Funcionario> Funcionario { get; set; }
    }
}
