Console.WriteLine("Type two values");

string[] value = Console.ReadLine().Split(' ');

int a = int.Parse(value[0]);
int b = int.Parse(value[1]);

if (a % b == 0 || b % a == 0)
{
    Console.WriteLine("The numbers are multiples");
}
else
{
    Console.WriteLine("The numbers aren't multiples");
}