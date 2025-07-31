using System.Collections.Generic;
using System.Globalization;
using Ex002;

List<Funcionarios> lista = new List<Funcionarios>();

Console.Write("Quantos funcionarios serao cadastrados?");
    int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int id = i;

    Console.Write("Nome: ");
        string nome = Console.ReadLine();

    Console.Write("Salario: ");
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    lista.Add(new Funcionarios(id, nome, salario)); //add um novo funcionario na lista
    Console.WriteLine();
}

Console.Write("Digite o ID do funcionário que terá aumento: ");
    int buscaId = int.Parse(Console.ReadLine());

Funcionarios FuncionarioBuscado = lista.Find(x => x.ID == buscaId); //para cada funcionario (x) na lista, verifique se funcionario.ID (x.ID) eh igual a buscaId

if (FuncionarioBuscado != null)
{
    Console.Write("Digite a porcentagem de aumento: ");
    double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    FuncionarioBuscado.AumentoSalario(aumento);
}
else
{
    Console.WriteLine("Funcionário com esse ID não foi encontrado.");
}

Console.WriteLine("\nLista atualizada de funcionários:");
foreach (Funcionarios funcionario in lista)
{
    Console.WriteLine(funcionario);
}