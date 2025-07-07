using System;
using System.Globalization;
using Estoque;

Produto p = new Produto();

Console.WriteLine("Entre os dados do produto: ");

Console.WriteLine("Nome: ");
p.Nome = Console.ReadLine();

Console.WriteLine("Valor: ");
p.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Quantidade no estoque: ");
p.Qntd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do produto: " + p);
Console.ReadKey();
