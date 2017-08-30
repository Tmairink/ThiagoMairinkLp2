using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();
            tri.Altura = int.Parse(Console.ReadLine());
            tri.Base = int.Parse(Console.ReadLine());

            tri.Caulculo();

            Console.WriteLine(tri.Area);
        }
    }
}
