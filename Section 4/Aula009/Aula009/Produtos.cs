using System.Globalization;

namespace Prod
{
    class Produtos
    {
        public string nome;
        public double valor;
        public int qntd;

        public double ValorTotalEstoque() //funcao
        {
            return (valor * qntd);
        }

        public void AddProdutos(int quantidade) //funcao
        {
            qntd += quantidade;
        }

        public void RemoverProdutos(int quantidade) //funcao
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
