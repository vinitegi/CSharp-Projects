using System;

namespace Medidas
{
public class Retangulo //se usar o 'public' permite o acesso da classe de outros programas
{
    public double Largura;
    public double Altura;

    public double Area()
    {
        return Largura * Altura;
    }

    public double Perimetro()
    {
        return (Largura * 2) + (Altura * 2);
    }

    public double Diagonal()
    {
        return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
    }
}
}

