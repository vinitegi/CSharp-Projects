using System.Globalization;

Console.Write("Digite a cotação atual do dolar: ");
    double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite quantos dolares você irá comprar: ");
    double quantidade  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double result = ConversorDeMoeda.Calculadora(quantidade, cotacao);

Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

Console.ReadKey();