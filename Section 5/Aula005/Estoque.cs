using System;
using System.Globalization;

namespace SistemaEstoque
{
    class Produtos
    {
        private string _nome;
        public double Valor { get; private set; }
        public int Quantidade { get; set; }

        public Produtos()
        {
        }

        public Produtos(string nome, double valor, int quantidade)
        {
            _nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }
        //===================================================================================

        // AutoProperties em C#:
        /*É uma forma siplificada de se declarar propriedades que não necessitam de lógicas particulares para as operações get e set
         */

        public string Nome 
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) //se o valor (nome) nao for vazio e maior de 1
                {
                    _nome = value;
                }
            }
        }


        //===================================================================================

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
            return _nome
                + ", $ "
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + "unidades, Total: $ "
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
