using System;

public class ConversorDeMoeda
{
	public static double Iof = 6.0;

	static public double Calculadora(double quantidade, double cotacao)
	{
		double total = quantidade * cotacao;
		return total + total * Iof / 100;
	}
}
