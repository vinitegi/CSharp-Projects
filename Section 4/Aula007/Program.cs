using Aula007;
using System.Globalization;

Triangulo X, Y;
X = new Triangulo();
Y = new Triangulo();

Console.WriteLine("Entre com as medidas do triangulo X:");
X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (X.A + X.B + X.C) / 2;
double areaX = Math.Sqrt(p * (p - X.A) * (p - X.B) * (p - X.C));

Console.WriteLine("Entre com as medidas do triangulo Y:");
Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

p = (Y.A + Y.B + Y.C) / 2;
double areaY = Math.Sqrt(p * (p - Y.A) * (p - Y.B) * (p - Y.C));

Console.WriteLine("Area do triangulo X: " + areaX.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Area do triangulo Y: " + areaY.ToString("F2", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior Area: X");
}
else if (areaX < areaY)
{
    Console.WriteLine("Maior Area: Y");
}
else
{
    Console.WriteLine("As areas sao iguais");
}