//ALISON GISELLE ESCOTO SAUCEDA - 202210010098
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._1___Calculadora
{
    internal class funciones
    {
        public double Suma(double x, double y)
        {
            return x + y;
        }
        public double Resta(double x, double y)
        {
            return x - y;
        }

        public double Multiplicacion(double x, double y)
        {
            return x * y;
        }
        public double Division(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("NO ES POSIBLE DIVIDIR ENTRE CERO");
            }
            return x / y;
        }
    }
}
