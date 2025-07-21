using System.Globalization;
using SistemaEstoque;

Produtos p = new Produtos("TV", 500, 10);

p.Nome = "TV 4K";

Console.WriteLine(p.Nome);
Console.WriteLine(p.Valor);
Console.WriteLine(p.Quantidade);


Console.ReadKey();
