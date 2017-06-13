using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MeuIntParce
{
    class Program
    {
        static void Main(string[] args)
        {
            int mult = 1, n=0, i=0;
            string s;
            s = Console.ReadLine();
            for (n = s.Length - 1; n >= 0; n--)
            {
                i += (s[n] - 48) * mult;
                mult = mult * 10;
            }
            Console.WriteLine(i);



        }
    }
}
