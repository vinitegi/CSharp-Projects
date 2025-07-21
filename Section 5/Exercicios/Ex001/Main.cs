using System;
using System.Globalization;
using Bank;

Console.Write("Entre o número da conta: ");
int Id = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string Titular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char Resp = char.Parse(Console.ReadLine());

BankAccount conta;

if (Resp == 's' || Resp == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new BankAccount(Id, Titular, depositoInicial);

    Console.WriteLine("\nDados da conta:");
    Console.WriteLine(conta);
}
else
{
    conta = new BankAccount(Id, Titular);
    Console.WriteLine(conta);
}

Console.WriteLine("Entre um valor para o deposito: ");
double Valor = double.Parse((Console.ReadLine()));
conta.Depositar(Valor);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);

Console.WriteLine("Entre um valor para o saque: ");
Valor = double.Parse((Console.ReadLine()));
conta.Sacar(Valor);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);

Console.ReadKey();
