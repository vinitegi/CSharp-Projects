using System;
using System.Globalization;
using Estoque;

Produto p = new Produto();

Console.WriteLine("Entre os dados do produto: ");

Console.Write("Nome: ");
p.Nome = Console.ReadLine();

Console.Write("Valor: ");
p.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade no estoque: ");
p.Qntd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do produto: " + p);
Console.ReadKey();
