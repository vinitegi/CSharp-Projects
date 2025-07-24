double? x = null;
double? y = 10.0;


Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(y.GetValueOrDefault());

Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);

if (x.HasValue)
    Console.WriteLine(x.Value);
else
    Console.WriteLine("X is null");

if (y.HasValue)
    Console.WriteLine(y.Value);
else 
    Console.WriteLine("Y is null");

double ? a = null;
double b = a ?? 0.0; //se a != NULL, b = a; senao b = 0.0

Console.WriteLine(b);


