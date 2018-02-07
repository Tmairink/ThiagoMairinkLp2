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
            cmd.CommandText = String.Format(@"SELECT AnoDeLanc, Id
                                              FROM Jogo;");
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                List<int> delet = new List<int>();
                while (reader.Read())
                {

                    int AnoLanc = reader.GetInt32(0);
                    int idJogo = reader.GetInt32(1);
                    int idadeJogo = ano - AnoLanc;
                    if (idadeJogo > 8)
                    {
                        delet.Add(idJogo);                        
                    }
                }
                cmd.Connection.Close();
                for (int f = 0; f < delet.Count; f++)
                {
                    cmd.CommandText = String.Format(@"DELETE 
                                                      FROM Jogo
                                                      WHERE Id = {0};", delet[f]);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
                Console.WriteLine("Deletado {0} Cadastro(s) com mais de 8 anos de lancamento", delet.Count);
            }

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
                        break;
                    }
                    else
                        Console.WriteLine("Erro");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
