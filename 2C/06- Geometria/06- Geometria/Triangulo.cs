using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__Geometria
{
    class Triangulo
    {
        public double Area;
        public double Altura;
        public double Base;
        

        public double Caulculo()
        {
            Area = (Base * Altura) / 2;
            return Area;

        }
    }
}
