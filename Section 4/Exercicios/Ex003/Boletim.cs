using System;
using System.Globalization;

namespace PerfilAluno
{
    public class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public void Avaliar()
        {
            double NotaFinal = N1 + N2 + N3;

            Console.WriteLine("Nota Final = " + NotaFinal.ToString("F2", CultureInfo.InvariantCulture));

            if (NotaFinal > 60)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram {0} pontos", (60 - NotaFinal).ToString("F2", CultureInfo.InvariantCulture));
            }
        }

    }
}

