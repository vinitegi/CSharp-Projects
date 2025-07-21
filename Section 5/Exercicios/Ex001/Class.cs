using System;
using System.Globalization;

namespace Bank
{
    class BankAccount
    {
        //propriedades
        public int ID { get; private set; } //private set -> o ID nao podera ser alterado
        public string Titular { get; set; }
        public double Saldo { get; private set; } //private -> so sera alterado por meio de funcoes, nao livremente

        private const double TaxaSaque = 5.00;

        //contrutores
        public BankAccount(int iD, string titular)
        {
            ID = iD;
            Titular = titular;
        }
        public BankAccount(int iD, string titular, double depositoInicial) : this(iD, titular)
        {
            Depositar(depositoInicial);
        }


        //membros
        public void Depositar (double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            Saldo -= (valor + TaxaSaque);
        }


        //tostring
        public override string ToString()
        {
            return "Conta" 
                + ID + ", Titular: "
                + Titular + ", Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture)
                + "\n";
        }
    }
}

