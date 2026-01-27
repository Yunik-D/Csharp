using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        public Produto(string nome, double preco)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Informe um nome válido para o produto.");

            if (preco < 0)
                throw new ArgumentException("Valor do produto não pode ser negativo.");

            Nome = nome;
            Preco = preco;
        }

        
    }
}
