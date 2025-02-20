using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de Escritorio";

byte idade = 30;
int codigo = 5900;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos: ");
Console.WriteLine($"Computador, cujo o preco eh R$ {preco1}");
Console.WriteLine($"Mesa de escritorio, cujo o preco eh R$ {preco2}");
Console.WriteLine("\n");

Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero: '{genero}'");

Console.WriteLine($"Medida com oito casas descimais: {medida:F8}");
Console.WriteLine($"Arredondando para tres casas: {medida:F3}");
Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");