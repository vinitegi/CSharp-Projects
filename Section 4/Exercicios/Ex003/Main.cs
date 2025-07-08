using System;
using System.Globalization;
using PerfilAluno;

Aluno estudante = new Aluno();

Console.Write("Nome do aluno: ");
    estudante.Nome = Console.ReadLine();

do
{
    Console.WriteLine("Digite as três notas do aluno:");
    estudante.N1 = double.Parse(Console.ReadLine());
    estudante.N2 = double.Parse(Console.ReadLine());
    estudante.N3 = double.Parse(Console.ReadLine());

    if (estudante.N1 > 30 || estudante.N2 > 35 || estudante.N3 > 35)
    {
        Console.WriteLine("Alguma nota excede o valor máximo permitido. Digite novamente.\n");
    }
}
while (estudante.N1 > 30 || estudante.N2 > 35 || estudante.N3 > 35);

Console.WriteLine();
estudante.Avaliar();
Console.ReadKey();



