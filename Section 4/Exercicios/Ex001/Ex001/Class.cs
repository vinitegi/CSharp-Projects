using System;

namespace ClasseEx001
{
    public class Pessoa
    {
        public string nome;
        public int idade;

        public static Pessoa MaiorIdade(Pessoa P1, Pessoa P2)
        //adionando o 'static' o método MaiorIdade pode ser chamado diretamente pela classe Pessoa
        {
            if (P1.idade > P2.idade)
            {
                return P1;
            } else
            { 
                return P2;
            }

        }
    }
}
