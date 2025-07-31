/*========================= LISTAS =========================
 * 
 *Lista é uma estrutura de dados:
 *  Homogêneas (elementos do mesmo tipo)
 *  Ordenadas (elementos acessados por meio de posições)
 *  Inicia vacia, e seus elementos são alocados sob demanda
 *  Cada elemento ocupa um "nó" da lista
 *  
 *Classe: List
 *Namespace: System.Collections.Generic
 *
 *Vantagens:
 *  Tamanho variável
 *  Facilidade pára se realizar inserções e deleções
 *  
 *Desvantagens: 
 *  Acesso sequencial aos elementos
 */

using System.Collections.Generic;

List<string> list = new List<string>();

list.Add("Maria"); //Add -> adiciona por padrao ao final da lista
list.Add("Alex");
list.Add("Bob");
list.Add("Anna");

list.Insert(2, "Marco"); //Insert -> adiciona no indice desejado

foreach (string name in list)
{
    Console.WriteLine(name);
}

Console.WriteLine("List Count = " + list.Count);

string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine("First 'A': " + s1);

string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("Last 'A': " + s2);

int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("First position 'A': " + pos1);

int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Last position 'A': " + pos2);

//=========================================================

List<string> list2 = list.FindAll(x => x.Length == 5);
Console.WriteLine("\n===========================================");
foreach (string s in list2)
{
    Console.WriteLine(s);
}

list.RemoveRange(2, 2);
Console.WriteLine("\n===========================================");
foreach (string s in list)
{
    Console.WriteLine(s);
}

list.RemoveAll(x => x[0] == 'M');
Console.WriteLine("\n===========================================");
foreach (string s in list)
{
    Console.WriteLine(s);
}

