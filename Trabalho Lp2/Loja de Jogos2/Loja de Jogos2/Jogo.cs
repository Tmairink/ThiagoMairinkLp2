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
        public string nome;
        public string genero;
        public string plataforma;

        public int preço;
        public int ano;


        public void Cadastro(string Nome, int Preço, int Ano, string Genero, string Plataforma)
        {
            nome = Nome;
            genero = Genero;
            ano = Ano;
            preço = Preço;
            plataforma = Plataforma;

            SqlConnection conexao = new SqlConnection("Data Source = localhost; Initial Catalog = LojaDeJogos; Integrated Security = SSPI;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = String.Format(@"Insert 
                                            Into Jogo
                                            Values('{0}', {1}, {2}, '{3}', '{4}');",nome, preço, ano, genero, plataforma);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
