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
            

            string Nome, Genero, Plataforma;
            int Preço, Ano;
            
            int Quantidade = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                Preço = Convert.ToInt32(Console.ReadLine());
                Ano = Convert.ToInt32(Console.ReadLine());
                Nome = Console.ReadLine();
                Genero = Console.ReadLine();
                Plataforma = Console.ReadLine();
                Jogo caguei = new Jogo();
                caguei.Cadastro(Nome, Preço, Ano, Genero, Plataforma,Quantidade);
            }
            else if (x == 2)
            {

            }
            else if (x == 3)
            {

            }
            else
                Console.WriteLine("erro");
        }
    }
}
