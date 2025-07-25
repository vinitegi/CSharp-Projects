using System.Globalization;


double soma = 0;

Console.Write("Digite o numeo de pessoas: ");
    int n = int.Parse(Console.ReadLine());

double[] altura = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Digite a altura de pessoa numero " + (i + 1) + ": ");
    altura[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    soma += altura[i];
}

Console.WriteLine("Média = " +  (soma / n).ToString("F2", CultureInfo.InvariantCulture) + " m");