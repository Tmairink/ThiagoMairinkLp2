using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_De_Jogos
{
    class Jogo
    {
        SqlConnection conexao = new SqlConnection("Data Source = localhost; Initial Catalog = LojaDeJogos; Integrated Security = SSPI;");
        SqlCommand cmd = new SqlCommand();

        public void Cadastro(string Nome)
        {
            cmd.Connection = conexao;
            cmd.CommandText = String.Format(@"SELECT DISTINCT Nome, Quantidade
                                              FROM Jogo 
                                              WHERE Nome ='{0}' ", Nome);
            string nome = "kdkdjgs";
            int quantidade = 0;
            int Quantidade = 0;
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read() == true)
                {
                    nome = reader.GetString(0);
                    quantidade = reader.GetInt32(1);
                }
            }
            cmd.Connection.Close();

            if (Nome!= nome)
            {
                string Genero, Plataforma;
                int Preço, Ano;

                Console.Write("Quantidade de Jogos:");
                Quantidade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Preço do Jogo:");
                Preço = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ano de Lançamento do Jogo:");
                Ano = Convert.ToInt32(Console.ReadLine());
                Console.Write("Genero do Jogo:");
                Genero = Console.ReadLine();
                Console.Write("Plataforma do Jogo:");
                Plataforma = Console.ReadLine();

                cmd.Connection = conexao;
                cmd.CommandText = String.Format(@"Insert 
                                                  Into Jogo(Nome, Genero, Plataforma, AnoDeLanc, Preco, Quantidade)
                                                  Values('{0}', '{1}', '{2}', {3}, {4}, {5});", Nome, Genero, Plataforma, Ano, Preço, Quantidade);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            else if(Nome == nome)
            {
                Console.Write("Quantidade de Jogos:");
                Quantidade = Convert.ToInt32(Console.ReadLine());
                quantidade = quantidade + Quantidade;
                cmd.Connection = conexao;
                cmd.CommandText = String.Format(@"UPDATE Jogo
                                                  SET Quantidade = {0}
                                                  WHERE Nome = '{1}'; ", quantidade, Nome);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }
        public void Compra(string Nome)
        {
            cmd.Connection = conexao;
            cmd.CommandText = String.Format(@"SELECT DISTINCT Nome , Preco, AnoDeLanc, Genero, Plataforma, Quantidade
                                              FROM Jogo 
                                              WHERE Nome ='{0}' ", Nome);

            string nome;
            int Preco = 0;
            int Ano = 0;
            string Genero;
            string Plataforma;
            int Quantidade = 0;

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read() == true)
                {
                    nome = reader.GetString(0);
                    Preco = reader.GetInt32(1);
                    Ano = reader.GetInt32(2);
                    Genero = reader.GetString(3);
                    Plataforma = reader.GetString(4);
                    Quantidade = reader.GetInt32(5);

                    Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", nome, Preco, Ano, Genero, Plataforma, Quantidade);
                }
            }
            cmd.Connection.Close();
            if (Quantidade >= 1)
            {
                Console.Write("Comprar? (S/N)");
                char M = Convert.ToChar(Console.ReadLine());

                if (M == 'S' || M == 's')
                {
                    Console.Write("Quantos Deseja?");
                    int q = Convert.ToInt32(Console.ReadLine());
                    if (Quantidade >= q)
                    {
                        q = Quantidade - q;

                        cmd.Connection = conexao;
                        cmd.CommandText = String.Format(@"UPDATE Jogo
                                                  SET Quantidade = {0}
                                                  WHERE Nome = '{1}'; ", q, Nome);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                    else
                    {
                        Console.WriteLine("Quantidade Indesejada");
                    }
                }
            }
            else
            {
                Console.WriteLine("Fora de estoque");
            }
        }

    }
}
