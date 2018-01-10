using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_De_Jogos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro-1  compra-2 troca-3");
            int x = Convert.ToInt32(Console.ReadLine());
            Jogo jg = new Jogo();
            if (x == 1)
            {
                string Nome;
                Console.Write("Nome do Jogo:");
                Nome = Console.ReadLine();
                jg.Cadastro(Nome);
                
            }
            else if (x == 2)
            {
                Console.Write("Nome do Jogo a ser comprado:");
                string Nome = Console.ReadLine();
                jg.Compra(Nome);
            }
            else if (x == 3)
            {

            }
            else
                Console.WriteLine("erro");
        }
    }
}
