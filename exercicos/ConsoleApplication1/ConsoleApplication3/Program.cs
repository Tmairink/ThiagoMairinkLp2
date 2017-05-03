
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            Console.WriteLine("quantos carros são?");
            N = Convert.ToInt32 (Console.ReadLine());
            string classe, potencial;
            string[] modelo= new string [N] ;
            double[] km= new double [N];
            double[] cv = new double[N];

            for (i=0; i <= N; i++)
            {
                Console.WriteLine("qual é o modelo do carro?");
                modelo[i] = Console.ReadLine();

                Console.WriteLine("Quantos km já foram percorridos com o carro?");
                km[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Quantos cavalos de potencia tem o carro?");
                cv[i] = Convert.ToDouble(Console.ReadLine());

                if (km[i] <= 5000)
                    classe = "novo";
                else if (km[i] > 5000 && km[i] < 30000)
                    classe = "seminovo";
                else
                    classe = "velho";

                if (cv[i] < 120)
                    potencial = "popular";
                else if (cv[i] >= 120 && cv[i] <= 200)
                    potencial = "forte";
                else
                    potencial = "poteeeente";

                Console.WriteLine("seu carro é um {0}-{1}-{2}", modelo[i], classe, potencial);
              
            }
                Console.ReadKey();



        }
    }
}
