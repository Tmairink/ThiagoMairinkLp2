using System;
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
                    AnoLanc = ano - AnoLanc;
                    if (AnoLanc > 8)
                    {
                        cmd.CommandText = String.Format(@"DELETE 
                                                          FROM Jogo
                                                          WHERE AnoDeLanc < '{0}';", ano);
                        i++;
                    }                    
                }
                Console.WriteLine("Deletado {0} Cadastro(s) com mais de 8 anos de lancamento", i);
            }
            cmd.Connection.Close();
            while (true)
            {
                try
                {
                    Jogo jg = new Jogo();
                    Console.WriteLine("Cadastro-1 || Compra-2 || Atualizaçao de Dados-3 || Sair-4");
                    int Menu = Convert.ToInt32(Console.ReadLine());
                    if (Menu == 1)
                    {
                        string Nome, Plataforma;
                        Console.Write("Nome do Jogo:");
                        Nome = Console.ReadLine();
                        Console.Write("Paltaforma do Jogo:");
                        Plataforma = Console.ReadLine();
                        jg.Cadastro(Nome, Plataforma);

                    }
                    else if (Menu == 2)
                    {
                        Console.Write("Nome do Jogo a ser comprado:");
                        string Nome = Console.ReadLine();
                        Console.Write("Plataforma do Jogo a ser comprado:");
                        string Plataforma = Console.ReadLine();
                        jg.Compra(Nome, Plataforma);
                    }
                    else if (Menu == 3)
                    {
                        Console.Write("Nome do Jogo a ser atualizado:");
                        string Nome = Console.ReadLine();
                        Console.Write("Paltaforma do Jogo:");
                        string Plataforma = Console.ReadLine();
                        jg.Atualizacao(Nome, Plataforma);

                    }
                    else if (Menu == 4)
                    {
                        goto sair;
                    }
                    else
                        Console.WriteLine("Erro");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            sair:;
        }
    }
}
