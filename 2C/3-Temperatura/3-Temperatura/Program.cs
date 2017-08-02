using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());
            TemperaturaCelsius Temp = new TemperaturaCelsius();

            Temp.Calke(C);
            
        }
    }
}
