using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weba2mvc.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string  Salario { get; set; }
        public string Sexo { get; set; }
        public DateTime Admicao { get; set; }



    }
}
