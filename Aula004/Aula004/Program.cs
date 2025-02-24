/*Conversao implicita entre tipos de variaveis
 *  float -> double
 */

float x = 4.5f;
double y = x;

Console.WriteLine(y); //isso pq float tem 4 bytes e double 8 bytes, sendo assim, da pra "guardar" um float dentro de um double. Mas nao o contrario

/*Cast - Conversao explicita de tipos
 * pode haver perda de dados caso seja feita tal acao
 */

double a = 5.1;
float b = (float)a;

//tambem pode converter uma variavel double ou float para int, basta realizar o mesmo processo

int c = (int)a;

Console.WriteLine(b);
Console.WriteLine(c);


int i = 5;
int j = 2;

double resultado = (double) i / j;
Console.WriteLine(resultado);
