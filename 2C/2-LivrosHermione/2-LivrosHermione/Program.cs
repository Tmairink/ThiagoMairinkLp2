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

            Livro[] livros= new Livro[i];
            for (int n = 0; n >= i; n++) 
            {
                livros[i]= new Livro();
                livros[i].DiasDevolu = Convert.ToInt32(Console.ReadLine());
                livros[i].paginas = Convert.ToInt32(Console.ReadLine());
                livros[i].titulos = Console.ReadLine();
                int calcufinal = livros[i].LerTd(pph, hpd);
                Console.WriteLine(calcufinal);
            }
            
        }
    }
}
