using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            Objeto2D obj = new Objeto2D();
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite X inicial: ");
            obj.x = int.Parse(Console.ReadLine());

            Console.Write("Digite Y inicial: ");
            obj.y = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.Write("digite comando: ");
                ConsoleKey comando = Console.ReadKey().Key;

                if (comando == ConsoleKey.RightArrow)
                {
                    obj.AndarParaDireita();

                }
                else if (comando == ConsoleKey.LeftArrow)
                {
                    obj.AndarParaEsquerda();
                }
				if(comando== ConsoleKey.UpArrow)
				{
					obj.AndarParaCima();
				}
				else if (comando== ConsoleKey.DownArrow)
				{
					obj.AndarParaBaixo();
				}

                if (obj.x > 0 && obj.x < b && obj.y > 0 && obj.y < a)
                {
                    Console.WriteLine("{0},{1}", obj.x, obj.y);
                }
                else
                {
                    Console.WriteLine("{0},{1}", obj.x, obj.y);
                    if (obj.x < 0)
                    {
                        Console.WriteLine("Saiu da Tela");
                        obj.x = 0;


                    }
                    else if(obj.x > b)
                    {
                        Console.WriteLine("Saiu da Tela");
                        obj.x = b;
                    }
					if(obj.y < 0)
					{
						Console.WriteLine("saiu da tela");
						obj.y = 0;
					}
					else if(obj.y>a)
					{
						Console.WriteLine("Saiu da tela");
						obj.y = a;
					}
                }
            }
           
        }
    }
}
