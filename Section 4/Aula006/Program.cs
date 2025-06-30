using System.Globalization;

double xA, xB, xC, yA, yB, yC;

Console.WriteLine("Entre com as medidas do triangulo X:");
xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triangulo Y:");
yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xA + xB + xC) / 2;
double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

p = (yA + yB + yC) / 2;
double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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