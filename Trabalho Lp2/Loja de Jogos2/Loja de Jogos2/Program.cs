using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Jogos2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Cadastro-1  compra-2 troca 3");
           int x =Convert.ToInt32( Console.ReadLine());
            Jogo caguei = new Jogo();
            if (x == 1)
            {
                string Nome, Genero, Plataforma;
                int Preço, Ano;
                int Quantidade = Convert.ToInt32(Console.ReadLine());
                Preço = Convert.ToInt32(Console.ReadLine());
                Ano = Convert.ToInt32(Console.ReadLine());
                Nome = Console.ReadLine();
                Genero = Console.ReadLine();
                Plataforma = Console.ReadLine();
                for (int i = 1; i <= Quantidade; i++)
                {
                    caguei.Cadastro(Nome, Preço, Ano, Genero, Plataforma);
                }
            }
            else if (x == 2)
            {
                string Nome = Console.ReadLine();
                caguei.Compra(Nome);
            }
            else if (x == 3)
            {

            }
            else
                Console.WriteLine("erro");
        }
    }
}
