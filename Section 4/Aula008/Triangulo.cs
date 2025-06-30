using System;
using System.Globalization;

namespace Aula008
{
    internal class Triangulo
    {
        public double A, B, C;

        public double Area()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
            return raiz;
        }

    }
}
