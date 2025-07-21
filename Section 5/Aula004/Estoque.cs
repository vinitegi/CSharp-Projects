using System;
using System.Globalization;

namespace SistemaEstoque
{
    class Produtos
    {
        private string _nome;
        private double _valor;
        private int _quantidade;

        public Produtos()
        {
            _quantidade = 10;
        }

        public Produtos(string nome, double valor, int quantidade)
        {
            _nome = nome;
            _valor = valor;
            _quantidade = quantidade;
        }
        //===================================================================================

        // Propriedades (Properties) em C#:
        // São usadas para acessar e modificar atributos privados de forma controlada.
        // A propriedade possui um "get" para retornar o valor e um "set" para atribuir um novo valor.
        // Com isso, é possível aplicar validações ou lógicas internas no acesso aos dados,
        // mantendo o encapsulamento da classe.

        public string Nome //propertie
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

        public double Preco
        {
            get { return _valor; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        //===================================================================================

        public double ValorTotal()
        {
            return _valor * _quantidade;
        }

        public void AddProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _valor.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + "unidades, Total: $ "
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
