using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula006
{
    internal class Calculator
    {
        public static void Triple(ref int x)
        {
            x *= 3;
        }
        public static void Double(int origin, out int result)
        {
            result = origin * 2;
        }
    }
}
