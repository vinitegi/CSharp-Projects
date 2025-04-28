using System.Globalization;

float xA, xB, xC, yA, yB, yC;

Console.WriteLine("Digite as medidas do triangulo X");
xA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xC = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite as medidas do triangulo Y");
yA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xA + xB + xC) / 2;
double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
Console.WriteLine($"A area do triangulo X: {areaX.ToString("F2", CultureInfo.InvariantCulture)}");

p = (yA + yB + yC) / 2;
double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
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


