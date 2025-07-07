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
