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

        public void Cadastro(string Nome, int Preço, int Ano, string Genero, string Plataforma,int Quantidade)
        {
          
                SqlConnection conexao = new SqlConnection("Data Source = localhost; Initial Catalog = LojaDeJogos; Integrated Security = SSPI;");
                SqlCommand cmd = new SqlCommand();
            
                cmd.Connection = conexao;
                cmd.CommandText = String.Format(@"Insert 
                                                  Into Jogo(Nome, Preco, AnoDeLanc, Genero, Plataforma)
                                                  Values('{0}', {1}, {2}, '{3}', '{4}');", Nome, Preço, Ano, Genero, Plataforma);
            cmd.Connection.Open();
            for (int i = 1; i >= Quantidade; i++)
            {               
                cmd.ExecuteNonQuery();
            }
            cmd.Connection.Close();
        }
    }
}
