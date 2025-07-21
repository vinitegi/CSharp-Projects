using System.Globalization;
using SistemaEstoque;

Produtos p = new Produtos("TV", 500, 10);
Console.WriteLine(p.GetNome());

p.SetNome("TV 4K");
Console.WriteLine(p.GetNome());


Console.ReadKey();

