using Aula008;
using System.Globalization;

Triangulo X, Y;
X = new Triangulo();
Y = new Triangulo();

Console.WriteLine("Entre com as medidas do triangulo X:");
X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = X.Area();
Console.WriteLine("Área de X = " + areaX);


Console.WriteLine("Entre com as medidas do triangulo Y:");
Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaY = Y.Area();
Console.WriteLine("Área de Y = " + areaY);
Console.ReadKey(); // ← segura o console
