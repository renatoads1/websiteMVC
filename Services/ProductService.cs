using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weba2mvc.Data;
using Weba2mvc.Models;

namespace Weba2mvc.Services
{
    public class ProductService
    {
        private readonly Weba2mvcContext _context;

        public ProductService(Weba2mvcContext context)
        {
            _context = context;
        }

        public List<Product> FindAll()
        {
            return _context.Product.ToList();
        }
        public void Insert(Product obj) 
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Product FindById(int id) 
        {
            return _context.Product.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            Product obj = _context.Product.Find(id);
            _context.Product.Remove(obj);
            _context.SaveChanges();
        }

    }
}
