using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Objeto2D
    {
        public int y;
        public int x;

        public void AndarParaDireita()
        {
            x = x + 3;
        }
        public void AndarParaEsquerda()
        {
            x = x - 3;
        }

    }
}
