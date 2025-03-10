Console.WriteLine("Digite a hora inicial e a hora final da sua jogatina:");

string[] horarios = Console.ReadLine().Split(' ');
int inicio = int.Parse(horarios[0]);
int final = int.Parse(horarios[1]);
int duracao;

if (inicio < final)
{
    duracao = inicio - final;
}
else
{
    duracao = 24 - inicio + final;
}

Console.WriteLine($"Voce jogou por {duracao}");