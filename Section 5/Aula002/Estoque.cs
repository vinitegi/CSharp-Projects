using System;
using System.Globalization;

namespace SistemaEstoque
{
    class Produtos
    {
        public string Nome;
        public double Valor;
        public int Quantidade;

        public Produtos()
        {
        }

        public Produtos(string nome, double valor, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public Produtos(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = 0;
        }

        public double ValorTotal()
        {
            return Valor * Quantidade;
        }

        public void AddProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + "unidades, Total: $ "
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
