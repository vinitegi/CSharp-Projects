using System.Globalization;

Console.WriteLine("--------------------------------\n" +
                  "CODIGO       PRODUTO        VALOR\n" +
                  "1            Hot-Dog        R4,00\n" +
                  "2            X-Salada       R4,50\n" +
                  "3            X-Bacon        R5,00\n" +
                  "4            Torrada        R2,00\n" +
                  "5         Refrigerante      R1,50\n");

Console.WriteLine("Digite o codigo do produto desejado e a quantidade: ");


string[] valores = Console.ReadLine().Split(' ');
int codigos =  int.Parse(valores[0]);
int qntd = int.Parse(valores[1]);

double total;

if (codigos == 1)
{
    total = qntd * 4.0;
}
else if (codigos == 2)
{
    total = qntd * 4.5;
}
else if (codigos == 3)
{
    total = qntd * 5.0;
}
else if (codigos == 4)
{
    total = qntd * 2.0;
}
else
{
    total = qntd * 1.5;
}

Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
