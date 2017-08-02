using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Temperatura
{
    class TemperaturaCelsius
    {
        double F;

        public double Calke(double C);
        {
            F = ((9*C)+32)/5;

            return F;
        }
    }
}
