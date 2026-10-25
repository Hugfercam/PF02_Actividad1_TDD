using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaTDD
{
    public class Funciones
    {
        public long CalcularFactorial(int n)
        {
            if (n < 0)
            {
                return -1;
            }

            long resultado = 1;

            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
