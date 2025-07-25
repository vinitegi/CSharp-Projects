using System.Globalization;
using Ex001;

Aluguel[] Quartos = new Aluguel[10];

Console.Write("Quantos estudantes vao alugar quartos? ");
    int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("\nQuartos disponíveis:");
    for (int j = 0; j < Quartos.Length; j++)
    {
        if (Quartos[j] == null)
        {
            Console.WriteLine($"Quarto {j} está disponível.");
        }
    }

    Console.WriteLine($"\nAluguel #{i}:");

    Console.Write("Nome: ");
        string nome = Console.ReadLine();
    Console.Write("Email: ");
        string email = Console.ReadLine();

    int Escolha;

    while (true) //verificação para saber se o quarto esta vazio ou nao -> evita sobrescrição
    {
        Console.Write("Escolha o seu quarto (0 a 9): ");
            Escolha = int.Parse(Console.ReadLine());

        if (Quartos[Escolha] == null)
        {
            break; //o quarto esta vazio, pode alugar
        } 
        else
        {
            Console.WriteLine("Este quarto ja esta ocupado, escolha outro.");
        }
    }
    Quartos[Escolha] = new Aluguel(nome, email);
}