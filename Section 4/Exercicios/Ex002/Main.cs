using System;
using System.Globalization;
using Colaborador;

Ficha Funcionario = new Ficha();

//Informacoes iniciais-------------------------------------------------
Console.Write("Nome: ");
    Funcionario.Nome = Console.ReadLine();

Console.Write("Salário Bruto: ");
    Funcionario.SalarioBruto = double.Parse(Console.ReadLine());

Console.Write("Imposto: ");
    Funcionario.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine("\nFuncionario: " + Funcionario);
//---------------------------------------------------------------------


//Aumento de salario---------------------------------------------------

Console.Write("Digite a porcentagem para aumentar o salario: ");
    double aumento = double.Parse(Console.ReadLine());
    Funcionario.AumentarSalario(aumento);

Console.WriteLine("Dados Atualizados: " + Funcionario);
//---------------------------------------------------------------------


Console.ReadKey();


