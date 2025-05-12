using System.Globalization;

namespace Prod
{
    class Produtos
    {
        public string nome;
        public double valor;
        public int qntd;

        public double ValorTotalEstoque()
        {
            return (valor * qntd);
        }

        public void AddProdutos(int quantidade)
        {
            qntd += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            qntd -= quantidade;
        }

        public override string ToString()
        {
            return 
                nome
                + ", R$ "
                + valor.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + qntd + " unidade em estoque, Total: R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
