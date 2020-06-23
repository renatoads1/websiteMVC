using System;
using System.Linq;
using System.Collections.Generic;


namespace Weba2mvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Saller> Sallers { get; set; } = new List<Saller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSaller(Saller saller)
        {
            Sallers.Add(saller);
        }
        public void RemovSaller(Saller saller)
        {
            Sallers.Remove(saller);
        }
        public double TotalSales(DateTime inicial,DateTime final)
        {
            return Sallers.Sum(saller => saller.TotalSales(inicial, final));
        }
    }
}
