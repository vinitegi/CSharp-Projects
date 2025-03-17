using System.Globalization;

double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (numero < 0 || numero > 100)
{
    Console.WriteLine("Numero fora do intervalo");
}
else if (numero <= 25.0)
{
    Console.WriteLine("Intervalo [0,25]");
}
else if (numero <= 50.0)
{
    Console.WriteLine("Intervalo (25,50]");
}
else if (numero <= 75.0)
{
    Console.WriteLine("Intervalo (50,75]");
}
else
{
    Console.WriteLine("Intervalo (75,100]");
}