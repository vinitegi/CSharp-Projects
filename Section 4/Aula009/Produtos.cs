using System;
using System.Globalization;

namespace Estoque
{
    internal class Produto
    {
        public string Nome;
        public double Valor;
        public int Qntd;

        public double ValorTotalEstoque()
        {
            return Valor * Qntd;
        }

        public void AddProdutos(int quantidade)
        {
            Qntd += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Qntd -= quantidade;
        }


        public override string ToString()
        {
            return Nome
                + ", $ "
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Qntd
                + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}

