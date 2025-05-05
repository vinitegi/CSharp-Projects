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

        public override string ToString()
        {
            return nome + ", R$ " + valor + ", " + qntd + " unidades em estoque";
        }
    }
}
