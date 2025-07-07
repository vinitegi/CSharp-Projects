using System;
using System.Globalization;
using Medidas;


Retangulo R = new Retangulo();

Console.WriteLine("Entre a largura e a altura do retângulo: ");
    R.Largura = double.Parse(Console.ReadLine());
    R.Altura = double.Parse(Console.ReadLine());

    Console.Write("\nArea = " + R.Area().ToString("F2", CultureInfo.InvariantCulture));
    Console.Write("\nPerimetro = " + R.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
    Console.Write("\nDiagonal = " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
Console.ReadKey();