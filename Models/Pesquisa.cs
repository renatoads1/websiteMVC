using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weba2mvc.Models
{
    public class Pesquisa
    {
        public int Id { get; set; }
        public string Perguntas { get; set; }
        public string Respostas { get; set; }
        public string Abrev { get; set; }
    }
}
