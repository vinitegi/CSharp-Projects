using System.Globalization;


//leitura de dados em string


string frase = Console.ReadLine();

Console.WriteLine(frase);

string[] vet = Console.ReadLine().Split(' ');
string p1 = vet[0];
string p2 = vet[1];
string p3 = vet[2];

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

//leitura de dados de numeros e char
//'Console.ReadLine()' faz a leitura apenas de strings. Portanto, usa-se 'tipoDaVariavel.Parse(Console.ReadLine()' para a leitura de outros tipos de variaveis

//int n1 = int.Parse(Console.ReadLine());
//char ch = char.Parse(Console.ReadLine());
//double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//teste pratico
string[] str = Console.ReadLine().Split(' ');
string nome = str[0];
char sexo = char.Parse(str[1]);
int idade = int.Parse(str[2]);
double altura = double.Parse(str[3], CultureInfo.InvariantCulture);

//Console.WriteLine(n1);
//Console.WriteLine(ch);
//Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
