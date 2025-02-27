using System.Globalization;

//leitura de dados em string

string frase = Console.ReadLine();

Console.WriteLine(frase);

string[] vet = Console.ReadLine().Split(' ');
string p1 = vet[0];
string p2 = vet[1];
string p3 = vet[2];

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

//leitura de dados de numeros e char

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

