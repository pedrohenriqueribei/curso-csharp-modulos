using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    class Produto
    {
        private string Nome;
        private double Preco;
        private int Quantidade;

        public Produto (string nome, double preco, int quant)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quant;
        }

        public Produto (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto()
        {

        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quant)
        {
            Quantidade += quant;
        }

        public void RemoverProdutos(int quant)
        {
            Quantidade -= quant;
        }

        public override string ToString()
        {
            return "Nome: " + Nome +"\n"
                + "R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "Quantidade: " + Quantidade
                ;
        }
    }
}
