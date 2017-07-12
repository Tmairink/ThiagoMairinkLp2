using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            int pph = Convert.ToInt32(Console.ReadLine());
            int hpd = Convert.ToInt32(Console.ReadLine());
            int ndl = Convert.ToInt32(Console.ReadLine());
            int inx;

            Livro[] Livros= new Livro[ndl];
            for (int n = 0; n < ndl; n++)
            {
                Livros[n] = new Livro();
                Livros[n].DiasDevolu = Convert.ToInt32(Console.ReadLine());
                Livros[n].NPaginas = Convert.ToInt32(Console.ReadLine());
                Livros[n].Titulo = Console.ReadLine();
                Console.WriteLine(Livros[n].LerTd(pph, hpd) + "Dias para ler todo o livro");
            }

            for (int n = 0; n < ndl; n++)
            {
                inx = Livros[n].DiasDevolu - Livros[n].LerTd(pph, hpd);

                if (inx == 0 || inx < 0)
                {
                    Console.WriteLine(Livros[n].Titulo + "imposivel de ler");

                }
                else 
                {
                    Console.WriteLine(Livros[n].Titulo + "possivel de ler");
                }
            }
        }
    }
}
