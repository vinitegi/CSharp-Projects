using System.Globalization;

Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
int rooms = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o valor do produto?");
double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] vet = Console.ReadLine().Split(' ');
string cor = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2]);

Console.WriteLine(nome);
Console.WriteLine(rooms);
Console.WriteLine(price);

Console.WriteLine($"A cor que voce escolheu foi {cor}, sua idade eh {idade} e a sua altura {altura.ToString("F2", CultureInfo.InvariantCulture)}");
