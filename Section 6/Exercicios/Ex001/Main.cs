using Ex001;

Aluguel[] Quartos = new Aluguel[10];

Console.Write("How many rooms gonna be rented? ");
int Quantidade = int.Parse(Console.ReadLine());

for (int i = 0; i < Quantidade; i++)
{
    Console.WriteLine($"\nAluguel #{i + 1}:");
    Console.Write("Nome: ");
        string nome = Console.ReadLine();
    Console.Write("Email: ");
        string email = Console.ReadLine();

    int RoomChoice;

    while (true) //vai rodar ate ser falso, ou ate o 'break'
    {
        Console.WriteLine("\n\nQuartos disponíveis:\n");
        Console.WriteLine("------------------------------------------------");
        for (int j = 0; j < Quartos.Length; j++)
        {
            if (Quartos[j] == null)
            {
                Console.WriteLine($"Quarto {j} está disponível.");
            }
        }
        Console.WriteLine("------------------------------------------------");

        Console.Write("Escolha um quarto de 0 a 9: ");
        RoomChoice = int.Parse(Console.ReadLine());

        if (RoomChoice < 0 || RoomChoice >= Quartos.Length) //verifica se a escolha esta entre o intervalo de 0 e 9
        {
            Console.WriteLine("Entrada invalida. Digite outro numero!");
        }
        else if (Quartos[RoomChoice] == null)
        {
            {
                break; //quarto esta vazio, sai do 'while'
            }
        }
        else
        {
            Console.WriteLine("Este quarto ja esta ocupado, escolha outro");
        }
    }

    Quartos[RoomChoice] = new Aluguel(nome, email);
}