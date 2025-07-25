using System.Globalization;
using Aula004;

double Media = 0;

Console.Write("Digite a quantidade de produtos que serão cadastrados: ");
int n = int.Parse(Console.ReadLine());

Product[] Vetor = new Product[n];

for (int i = 0; i < n; i++)
{
    Console.Write("\nDigite o nome do produto " + (i + 1) + ": ");
        string NomeTemp = Console.ReadLine();
    Console.Write("Digite o preço do produto " + (i + 1) + ": ");
        double ValorTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Vetor[i] = new Product { Name = NomeTemp, Price = ValorTemp};

    Media += Vetor[i].Price;
}

Console.WriteLine("Media de preço = " +  (Media/n).ToString("F2", CultureInfo.InvariantCulture));