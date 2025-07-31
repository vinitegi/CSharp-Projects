using System.Globalization;

namespace Ex002
{
    class Funcionarios
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salario { get; set; }

        public Funcionarios(int id, string nome, double salario) { 
            ID = id;
            Name = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            Salario += Salario * (porcentagem / 100);
        }

        public override string ToString()
        {
            return ID + ", " + Name + ", R$ " + Salario.ToString("F2", CultureInfo.InvariantCulture);

        }
        }
    }
