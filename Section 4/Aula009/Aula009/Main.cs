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

Console.WriteLine("Digite quantos produtos serão adicionado ao estoque:");
    int novaQntd = int.Parse(Console.ReadLine());
    p.AddProdutos(novaQntd); //função criada na classe

Console.WriteLine("Dados atualizados: " + p);
