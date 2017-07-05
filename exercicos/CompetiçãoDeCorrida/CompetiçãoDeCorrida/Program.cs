using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetiçãoDeCorrida
{
    class Program
    {
        static void Main(string[] args)
        {
            double MenorT = 100000; string Venc = "Eu";

            Console.WriteLine("informe o numero de competidores");
            int N = int.Parse (Console.ReadLine());


            
            Competidor[] competidores = new Competidor[N];

            for (int i = 0; i < N; i++)
            {

                Console.WriteLine("Informe o nome do competidor {0} ", (i + 1));
                competidores[i] = new Competidor();

                competidores[i].Nome = Console.ReadLine();
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Informe o tempo 1 do competidor {0}",(i + 1));
                competidores[i].Tempo1 = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Informe o tempo 2 do competidor {0}",(i + 1));
                competidores[i].Tempo2 = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Informe o tempo 3 do competidor {0}", (i + 1));
                competidores[i].Tempo3 = double.Parse(Console.ReadLine());
            }

            double[] Tempos = new double[N];

            for (int i = 0; i < N; i++ )
            {

                Tempos[i] = competidores[i].CalcularTempo();

                if ( Tempos[i] < MenorT)
                {
                    MenorT = Tempos[i];

                    Venc = competidores[i].Nome;
                }

            }

            Console.WriteLine(Venc);

        }
    }
}
