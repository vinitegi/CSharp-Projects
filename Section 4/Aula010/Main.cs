using System;
using System.Globalization;
using Curso;


Console.Write("Entre o valor do raio: ");
double Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circ = Calculadora.Circunferencia(Raio);
double vol = Calculadora.Volume(Raio);


Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

Console.ReadKey();
