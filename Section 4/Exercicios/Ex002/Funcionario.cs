using System;
using System.Globalization;

namespace Colaborador
{
    public class Ficha
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double aumento)
        {
            SalarioBruto *= (1 + aumento / 100);
        }

        public override string ToString()
        {
            return Nome
            + ", $"
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

