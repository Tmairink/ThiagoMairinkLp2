﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_De_Jogos
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexao = new SqlConnection("Data Source = localhost; Initial Catalog = LojaDeJogos; Integrated Security = SSPI;");
            SqlCommand cmd = new SqlCommand();

            int ano = DateTime.Now.Year;
            cmd.Connection = conexao;
            cmd.CommandText = String.Format(@"SELECT AnoDeLanc
                                              FROM Jogo;");
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read() == true)
                {
                    
                    int AnoLanc = reader.GetInt32(0);
                    int ona = ano - AnoLanc;
                    if (ona > 8)
                    {
                        cmd.CommandText = String.Format(@"DELET 
                                                          FROM Jogo
                                                          WHERE AnoDeLanc < '{0}';", ano);
                        i++;
                    }
                    Console.WriteLine("Deletado {0} Cadastro(s) com mais de 8 anos de lancamento", i);
                }
            }
            cmd.Connection.Close();
            while(true)
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
                else if (x == 4)
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
}
