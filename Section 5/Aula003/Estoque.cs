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

        // Encapsulamento:
        // Técnica da programação orientada a objetos que protege os dados de uma classe.
        // Os atributos são declarados como "private" e só podem ser acessados/modificados
        // por meio de métodos ou propriedades públicas (get e set).
        // Isso permite controlar como os dados são alterados, garantindo segurança,
        // organização e manutenção do código a longo prazo.

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1) //se o nome nao for vazio e maior de 1
            {
                _nome = nome;
            }
        }

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
