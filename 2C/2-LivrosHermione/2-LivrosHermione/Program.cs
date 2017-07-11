using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            int pph = Convert.ToInt32(Console.ReadLine());
            int hpd = Convert.ToInt32(Console.ReadLine());
            int i = Convert.ToInt32(Console.ReadLine());
            int inx, calcufinal=0;

            Livro[] livros= new Livro[i];
            for (int n = 0; n <= i; n++)
            {
                livros[n] = new Livro();
                livros[n].DiasDevolu = Convert.ToInt32(Console.ReadLine());
                livros[n].paginas = Convert.ToInt32(Console.ReadLine());
                livros[n].titulos = Console.ReadLine();
                Console.WriteLine(livros[n].LerTd(pph, hpd));
            }
            for (int n = 0; n <= i; n++)
            {
                inx =  livros[n].DiasDevolu - livros[n].LerTd(pph, hpd);

                if(inx==0)
                {
                    Console.WriteLine(livros[n].titulos);

                }
                else
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}
