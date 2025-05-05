using System;
using System.Globalization;
using Prod; //namespace da classe -> 'Prod'

Produtos p = new Produtos();

Console.WriteLine("Digite os dados do produto:");

Console.WriteLine("Nome:");
    p.nome = Console.ReadLine();

Console.WriteLine("Valor: ");
    p.valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Estoque: ");
    p.qntd = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto: " + p);
