using Aula007;
using System.Globalization;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Digite as medidas do triangulo X");
x.A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite as medidas do triangulo Y");
y.A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();
Console.WriteLine($"A area do triangulo X: {areaX.ToString("F2", CultureInfo.InvariantCulture)}");

double areaY = y.Area();
Console.WriteLine($"A area do triangulo Y: {areaY.ToString("F2", CultureInfo.InvariantCulture)}");

if (areaX > areaY)
{
    Console.WriteLine("A area de X eh maior");
} else if (areaX < areaY)
{
    Console.WriteLine("A area de Y eh maior");
} else
{
    Console.WriteLine("As areas sao iguais");
}


