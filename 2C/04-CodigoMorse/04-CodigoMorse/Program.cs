using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario = Console.ReadLine();
            int num=int.Parse(Console.ReadLine());
            Mensagem sms = new Mensagem();
            if (num==1)
            {
                Console.WriteLine(usuario);
            }
            else if (num == 2)
            {
                Console.WriteLine(sms.Som(usuario));
            }
            else if(num ==3)
            {
                Console.WriteLine(sms.Morse(usuario));
            }
            else
            {
                Console.WriteLine("saiu");
            }
            
        }
    }
}
