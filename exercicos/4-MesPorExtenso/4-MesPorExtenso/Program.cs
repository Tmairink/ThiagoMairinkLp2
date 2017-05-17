using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MesPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, m, a;
            Console.WriteLine("qual é o dia do mês meu patrao?");
            d= Convert.ToInt32(Console.ReadLine());
            if (d >= 0 && d < 31)
            {
                Console.WriteLine("qual é o mês do ano meu patrao?");
                m = Convert.ToInt32(Console.ReadLine());
                if (m >= 0 && m < 12)
                {
                    
                    Console.WriteLine("qual é o ano da década de hoje do mes de ano de seculo do milenio presente meu patrao?");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("{0}//{1}//{2}",d ,m.,a);
                }
                else
                {
                    Console.WriteLine("Mes Invalido");
                }

            }
            else
            {
                Console.WriteLine("Dia Invalido");

            }
        }
    }
}
