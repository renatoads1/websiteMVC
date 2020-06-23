using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weba2mvc.Data;
using Weba2mvc.Models;

namespace Weba2mvc.Services
{
    public class SallerService
    {
        private readonly Weba2mvcContext _context;

        public SallerService(Weba2mvcContext context)
        {
            _context = context;
        }
        public List<Saller> FindAll()
        {
           return _context.Saller.ToList();
        }
    }
}
