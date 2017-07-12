using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___LivrosHermione
{
    class Livro
    {
        public string Titulo;
        public int NuPaginas;
        public int DiasDevolu;
        public int LerTd(int pph, int hpd)
        {
            int pgd = pph * hpd;
            int calcf = NuPaginas / pgd;
            return calcf;
        }
    }
}
