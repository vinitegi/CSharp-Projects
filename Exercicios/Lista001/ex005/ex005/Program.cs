using System.Globalization;

int cod1, cod2, qte1, qte2;
double preco1, preco2, total;

Console.WriteLine("Digite o codigo da peca 1, a quantidade e o valor");
string[] valores = Console.ReadLine().Split(' ');
cod1 = int.Parse(valores[0]);
qte1 = int.Parse(valores[1]);
preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

Console.WriteLine("Digite o codigo da peca 2, a quantidade e o valor");
string[] valores2 = Console.ReadLine().Split(' ');
cod2 = int.Parse(valores2[0]);
qte2 = int.Parse(valores2[1]);
preco2 = double.Parse(valores2[2], CultureInfo.InvariantCulture);

total = (qte1 * preco1) + (qte2 * preco2);
Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
