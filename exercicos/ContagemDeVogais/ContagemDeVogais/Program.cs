using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemDeVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;
            letra = Console.ReadLine().ToUpper();
            int qnt = 0;

            for (int i = 0; i < letra.Length; i++)
            {
                if (letra[i] == 'A' || letra[i] == 'E' || letra[i] == 'I' || letra[i] == 'O' || letra[i] == 'U')
                {
                    qnt++;
                }
            }

            Console.WriteLine("A frase possui {0} vogais", qnt);
            Console.ReadKey();
        }
    }
}
