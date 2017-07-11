using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosHermione
{
    class Livro
    {
        
        public string titulos;
        public int paginas;
        public int DiasDevolu;
        public int LerTd(int pph, int hpd)
        {
            int pgd = pph * hpd;
            int calcf = paginas / pgd;
            return calcf;
        }
    }
    
}
