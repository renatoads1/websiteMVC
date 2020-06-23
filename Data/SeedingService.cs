using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weba2mvc.Models;
using Weba2mvc.Models.Enums;

namespace Weba2mvc.Data
{
    public class SeedingService
    {
        private Weba2mvcContext _context;
        public SeedingService(Weba2mvcContext context) 
        {
            _context = context;
        }
        public void Seed()
        {
            //usa o linq para testar se existe registro na tabela
            if ( _context.Department.Any() || _context.Saller.Any() || _context.SalesRecord.Any() || _context.Product.Any())
            {
                return;//este retorno mata a instrucão e o méthodo
            }
            //Departamentos
            Department d1 = new Department(1,"Informática");
            Department d2 = new Department(2,"Recurssos Humanos");
            Department d3 = new Department(3,"Marketing");
            Department d4 = new Department(4,"Contabilidade");
            Department d5 = new Department(5,"Financeiro");
            Department d6 = new Department(6,"Almoxarifado");
            Department d7 = new Department(7,"Desenvolvimento");

            //vendedores
            Saller s1 = new Saller(1,"Renato de Azevedo","renatolacerda@matur.com.br",new DateTime(1982,6,11),1000.00,d7);
            Saller s2 = new Saller(2, "Francisco Junior", "francisco.junior@matur.com.br", new DateTime(1982, 6, 11), 1050.00, d7);
            Saller s3 = new Saller(3, "Roger Guerra", "rogerguerra@matur.com.br", new DateTime(1982, 6, 11), 1700.00, d1);
            Saller s4 = new Saller(4, "Lucas Pinto", "lucaspinto@matur.com.br", new DateTime(1982, 6, 11), 2000.00, d1);

            //vendas 
            SalesRecord r1 = new SalesRecord(1,new DateTime(2020 , 6, 30), 5000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 6, 30), 5000.0, SaleStatus.Pending, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 6, 30), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 6, 30), 5000.0, SaleStatus.Canceled, s2);

            //produtos
            Product p1 = new Product(1, "000000000001", "Caneta","Caneta Esferografica Bique",1.00,2.00,550,true,new DateTime(2020,6,23));
            Product p2 = new Product(2, "000000000002", "Borracha", "Faber Castel", 0.50, 1.50, 550, true, new DateTime(2020, 6, 23));
            Product p3 = new Product(3, "000000000003", "PenDriver", "Scan DSK",10.00, 25.00, 25, true, new DateTime(2020, 6, 23));
            Product p4 = new Product(4, "000000000004", "Calculadora", "Calculadora h3 bit", 15.00, 32.00, 100, true, new DateTime(2020, 6, 23));

            //add
            _context.Department.AddRange(d1,d2,d3,d4,d5,d6,d7);
            _context.Saller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(r1, r2, r3, r4);
            _context.Product.AddRange(p1,p2,p3,p4);
            _context.SaveChanges();
        }
    }
}
