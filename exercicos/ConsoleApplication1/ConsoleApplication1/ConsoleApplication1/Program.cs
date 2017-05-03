using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             int N;
            Console.WriteLine("quantos carros são?");
            N = Convert.ToInt32(Console.ReadLine());
            string modelo;
            double km;
            int cv;

            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine("Modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Quilometragen");
                km = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Cavalos");
                cv = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(classificar(modelo, km, cv));
            }
        }

        public static string classificar(string modelo, double km, double cv)
        {
            string classe, potencial;
            if (km <= 5000)
                classe = "novo";
            else if (km > 5000 && km < 30000)
                classe = "seminovo";
            else
                classe = "velho";

            if (cv < 120)
                potencial = "popular";
            else if (cv >= 120 && cv <= 200)
                potencial = "forte";
            else
                potencial = "potente";

            return string.Format("seu carro é um {0}-{1}-{2}", modelo, classe, potencial);
        }
        
    }
}
