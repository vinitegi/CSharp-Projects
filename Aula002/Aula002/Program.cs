using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 126;
            int n2 = 321;
            int n3 = 2147483647;
            long n4 = 2147483648L; //sempre colocar um L ao final do valor de uma variavel do tipo 'long' para simbolizar o tipo da variavel
            float n5 = 4.5f; //obrigatorio colocar o 'f' ao final do valor da variavel, para simbolizar que se trata de uma variavel do tipo 'float' e nao do tipo 'double'
            double n6 = 4.5;

            /*
             * MUDANÇA TIPO DE VARIALVEL
             */

            bool completo = false; //valor verdade, veradeiro ou falso (0 e 1)
            char caracter = 'a';
            string nome = "otegi";

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(caracter);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
           
        }
    }
}