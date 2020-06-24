using System;

namespace Weba2mvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string CodBarras { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }
        public int QuantidadeEstoque { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public Product()
        {
        }

        public Product(int id, string codbarras,  string nome, string descricao, double precoCompra, double precoVenda, int quantidadeEstoque, bool ativo, DateTime dataCadastro)
        {
            Id = id;
            CodBarras = codbarras;
            Nome = nome;
            Descricao = descricao;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
            QuantidadeEstoque = quantidadeEstoque;
            Ativo = ativo;
            DataCadastro = dataCadastro;
        }
    }
}
