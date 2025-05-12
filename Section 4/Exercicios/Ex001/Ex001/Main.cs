using ClasseEx001;

Pessoa P1 = new Pessoa();
Pessoa P2 = new Pessoa();

//Pessoa 1
Console.WriteLine("Digite o nome da pessoa 1:");
    P1.nome = Console.ReadLine();
Console.WriteLine("Digite a idade da pessoa 1:");
    P1.idade = int.Parse(Console.ReadLine());

//Pessoa 2
Console.WriteLine("Digite o nome da pessoa 2:");
    P2.nome = Console.ReadLine();
Console.WriteLine("Digite a idade da pessoa 2:");
    P2.idade = int.Parse(Console.ReadLine());

//Verificação

Pessoa MaisVelha = Pessoa.MaiorIdade(P1, P2);
Console.WriteLine($"A pessoa mais velha é {MaisVelha.nome}, com {MaisVelha.idade} anos de idade.");