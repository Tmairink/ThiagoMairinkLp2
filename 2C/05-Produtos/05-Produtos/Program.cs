using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(1, "sabonete Francis 60g", 1.49);
            p.Reposicao(100);
            p.Retirada(20);
            //p.Retirada(90);

            Console.WriteLine(p.Imprimir());
        }
    }
}
