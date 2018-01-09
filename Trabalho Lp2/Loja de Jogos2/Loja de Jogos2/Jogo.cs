using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Jogos2
{
    class Jogo
    {

        SqlConnection conexao = new SqlConnection("Data Source = localhost; Initial Catalog = LojaDeJogos; Integrated Security = SSPI;");
        SqlCommand cmd = new SqlCommand();
 
        public void Cadastro(string Nome, int Preço, int Ano, string Genero, string Plataforma)
        {


            cmd.Connection = conexao;
            cmd.CommandText = String.Format(@"Insert 
                                                  Into Jogo(Nome, Preco, AnoDeLanc, Genero, Plataforma)
                                                  Values('{0}', {1}, {2}, '{3}', '{4}');", Nome, Preço, Ano, Genero, Plataforma);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void Compra(string Nome)
        {
            cmd.Connection = conexao;
            cmd.CommandText = String.Format(@"SELECT DISTINCT Nome , Preco, AnoDeLanc, Genero, Plataforma 
                                              FROM Jogo 
                                              WHERE Nome ='{0}' ", Nome);

            string nome;
            int Preco = 0;
            int Ano = 0;
            string Genero;
            string Plataforma;

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

                    Console.WriteLine("{0}, {1}, {2}, {3}, {4}", nome, Preco, Ano, Genero, Plataforma);
                }
            }
            cmd.Connection.Close();

            Console.WriteLine(Preco);
            



            //cmd.CommandText = String.Format(@"Delete From Jogo {0};", Nome);
        }
    }
}
