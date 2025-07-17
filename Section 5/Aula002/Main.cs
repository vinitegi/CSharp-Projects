using System.Globalization;
using SistemaEstoque;

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Preço: ");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade: ");
int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Produtos p = new Produtos(nome, valor, quantidade);

Produtos p2 = new Produtos(nome, valor);

Produtos p3 = new Produtos();


Console.WriteLine();

Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();


Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
int qte = int.Parse(Console.ReadLine());
p.AddProdutos(qte);


Console.WriteLine("\nDados atualizados: " + p + "\n");


Console.Write("Digite o número de produtos a ser removido do estoque: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);

Console.WriteLine("\nDados atualizados: " + p);

Console.ReadKey();

