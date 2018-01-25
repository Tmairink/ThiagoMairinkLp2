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
            Jogo jg = new Jogo();
            Console.WriteLine("Cadastro-1 || Compra-2 || Troca-3 || Atualizaçao de Dados-4");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                string Nome, Plataforma;
                Console.Write("Nome do Jogo:");
                Nome = Console.ReadLine();
                Console.Write("Paltaforma do Jogo:");
                Plataforma = Console.ReadLine();
                jg.Cadastro(Nome, Plataforma);
                
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
            else if(x==4)
            {
                Console.Write("Nome do Jogo a ser atualizado:");
                string Nome = Console.ReadLine();
                Console.Write("Paltaforma do Jogo:");
                string Plataforma = Console.ReadLine();
                jg.Atualizacao(Nome, Plataforma);

            }
            else
                Console.WriteLine("Erro");
        }
    }
}
