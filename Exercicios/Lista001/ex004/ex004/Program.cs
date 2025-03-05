using System.Globalization;

Console.WriteLine("Type your ID:");
    int ID = int.Parse(Console.ReadLine());

Console.WriteLine("How many hours you worked last month?");
    double hours = double.Parse(Console.ReadLine());

Console.WriteLine("How much you get paid per hour?");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Welcome back Worker Number {ID}");
Console.WriteLine($"Your salary is USD${(hours * salary).ToString("F2", CultureInfo.InvariantCulture)}");