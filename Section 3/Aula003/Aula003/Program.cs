using System.Globalization;

Console.WriteLine("---------------------------------------------------------------");

char genero = 'F';
int idade = 32;
double saldo = 10.325789;
string nome = "maria";

Console.WriteLine(genero);
Console.WriteLine(idade);
Console.WriteLine(saldo.ToString("F2"));
Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(nome);
Console.WriteLine("---------------------------------------------------------------");

//PlaceHolders
Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2}", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));

//Interpolacao
Console.WriteLine($"{nome} tem {idade} e saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)}");

//Contacatenacao de strings
Console.WriteLine(nome + " tem " + idade + " e saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture));
