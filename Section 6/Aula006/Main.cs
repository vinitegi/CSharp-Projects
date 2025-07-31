using Aula006;

int a = 10;
Calculator.Triple(ref a); //eh tipo um ponteiro, mas nao eh ao msm tempo
Console.WriteLine(a);

int b = 10;
int dobro;
Calculator.Double(b, out dobro);
Console.WriteLine(dobro);