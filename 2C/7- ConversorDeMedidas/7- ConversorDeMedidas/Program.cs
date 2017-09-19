using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__ConversorDeMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peso= 1 |Temperatura=2 |Distancia=3");
            int cv = Convert.ToInt32(Console.ReadLine());
            double id;
            id =Convert.ToDouble(Console.ReadLine());
            if (cv==1)
            {
                Console.WriteLine("Kg para G =1 || Kg para T =2 || Kg para Lbs=3 || G para Kg=4 || Tpara Kg =5 || Lbs para Kg=6");
                int ad = Convert.ToInt32(Console.ReadLine());
                if (ad==1)
                {
                     Console.WriteLine(Conversor.KgParaG( id));
                }
                else if (ad==2)
                {
                     Console.WriteLine(Conversor.KgParaT( id));
                }
                else if (ad==3)
                {
                     Console.WriteLine(Conversor.KgParaLbs( id));
                }
                else if (ad==4)
                {
                    Console.WriteLine(Conversor.GParaKg( id));
                }
                else if (ad==5)
                {
                     Console.WriteLine(Conversor.TParaKg( id));
                }
                else if (ad==6)
                {
                     Console.WriteLine(Conversor.LbsParaKg( id));
                }
            }
            else if(cv==2)
            {
                Console.WriteLine("F para C =1 || C para F =2 || C para K=3 || F para K=4 || K para C =5 || K para F =6");
                int ad = Convert.ToInt32(Console.ReadLine());
                if (ad == 1)
                {
                    Console.WriteLine(Conversor.FParaC(id));
                }
                else if (ad == 2)
                {
                    Console.WriteLine(Conversor.CParaF(id));
                }
                else if (ad == 3)
                {
                    Console.WriteLine(Conversor.CParaK(id));
                }
                else if (ad == 4)
                {
                    Console.WriteLine(Conversor.FParaK(id));
                }
                else if (ad == 5)
                {
                    Console.WriteLine(Conversor.KParaC(id));
                }
                else if (ad == 6)
                {
                    Console.WriteLine(Conversor.KParaF(id));
                }
            }
            else if(cv==3)
            {
                

            }
            else{
                throw new Exception();
            }
            
        }
    }
}
