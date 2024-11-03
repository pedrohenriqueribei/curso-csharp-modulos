using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double raio)
        {
            return 2.0 * raio * Pi;
        }

        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * raio * Math.Pow(raio, 3.0);
        }
    }
}
