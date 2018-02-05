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

        public void Cadastro(string Nome, string Plataforma)
        {
            try
            {
                cmd.Connection = conexao;
                cmd.CommandText = String.Format(@"SELECT DISTINCT Nome, Quantidade, Plataforma
                                              FROM Jogo 
                                              WHERE Nome ='{0}' And Plataforma = '{1}';", Nome, Plataforma);
                string nome = "Lllllll";
                string plataforma = "Ttttttt";
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
                        plataforma = reader.GetString(2);
                    }
                }
                cmd.Connection.Close();


                if (Nome != nome && plataforma != Plataforma)
                {
                    string Genero;
                    int Preço, Ano;

                    Console.Write("Quantidade de Jogos:");
                    Quantidade = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Preço do Jogo:");
                    Preço = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ano de Lançamento do Jogo:");
                    Ano = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Genero do Jogo:");
                    Genero = Console.ReadLine();


                    cmd.Connection = conexao;
                    cmd.CommandText = String.Format(@"Insert 
                                                  Into Jogo(Nome, Genero, Plataforma, AnoDeLanc, Preco, Quantidade)
                                                  Values('{0}', '{1}', '{2}', {3}, {4}, {5});", Nome, Genero, Plataforma, Ano, Preço, Quantidade);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    Console.WriteLine("Cadastrado com sucesso");
                }
                else if (Nome == nome && plataforma == Plataforma)
                {
                    Console.Write("Quantidade de Jogos:");
                    Quantidade = Convert.ToInt32(Console.ReadLine());
                    quantidade = quantidade + Quantidade;
                    cmd.Connection = conexao;
                    cmd.CommandText = String.Format(@"UPDATE Jogo
                                                  SET Quantidade = {0}
                                                  WHERE Nome = '{1}' And Plataforma = '{2}'; ", quantidade, Nome, Plataforma);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    Console.WriteLine("Cadastrado com sucesso");

                }

            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Compra(string Nome, string Plataforma)
        {
            try
            {
                cmd.Connection = conexao;
                cmd.CommandText = String.Format(@"SELECT Preco, AnoDeLanc, Genero, Quantidade
                                              FROM Jogo 
                                              WHERE Nome ='{0}' And Plataforma ='{1}'; ", Nome , Plataforma);
                int Preco = 0;
                int Ano = 0;
                string Genero;
                int Quantidade = 0;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read() == true)
                    {
                        Preco = reader.GetInt32(0);
                        Ano = reader.GetInt32(1);
                        Genero = reader.GetString(2);
                        Quantidade = reader.GetInt32(3);

                        Console.WriteLine("\nPreço: {0}.\nAno: {1}.\nGenêro {2}.\nPlataforma: {3}.\nQuantidade: {4}.", Preco, Ano, Genero, Plataforma, Quantidade);
                    }
                }
                cmd.Connection.Close();
                if (Quantidade >= 1)
                { 
                    Console.WriteLine("\n||Acima de 3 unidades desconto de 20%||");
                    Console.WriteLine("\nComprar? (S/N)");
                    char M = Convert.ToChar(Console.ReadLine());

                    if (M == 'S' || M == 's')
                    {
                        Console.WriteLine("\nQuantos Deseja?");
                        int q = Convert.ToInt32(Console.ReadLine());
                        if (Quantidade >= q)
                        {
                            Quantidade -= q;
                           

                            cmd.Connection = conexao;
                            cmd.CommandText = String.Format(@"UPDATE Jogo
                                                  SET Quantidade = {0}
                                                  WHERE Nome = '{1}'; ", Quantidade, Nome);
                            cmd.Connection.Open();
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();
                            if (q >= 3)
                            {
                                int qs = Preco * q ;
                                Console.WriteLine("O Valar da compra sem desconto foi de: {0}", qs);
                                double qd = (qs - (qs * 0.20));
                                Console.WriteLine("O Valar da compra Com desconto foi de: {0}", qd);
                            }
                            else
                                Console.WriteLine("O Valar da compra foi de: {0}", Preco * q);

                        }
                        else
                        {
                            Console.WriteLine("\nQuantidade Indesejada");
                        }
                    }
                }

                else
                {
                    Console.WriteLine("\nFora de estoque");
                }
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
        public void Atualizacao(string Nome,string Plataforma)
        {
            try
            {
                cmd.Connection = conexao;
                cmd.CommandText = String.Format(@"SELECT DISTINCT Nome, Plataforma
                                              FROM Jogo 
                                              WHERE Nome ='{0}' And Plataforma = '{1}'; ", Nome, Plataforma);
                string nome = "Lllllll";
                string plataforma = "Ttttttt";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read() == true)
                    {
                        nome = reader.GetString(0);
                        plataforma = reader.GetString(1);
                    }
                }

                cmd.Connection.Close();
                if (nome != "Lllllll")
                {
                    Console.WriteLine("1-Genero || 2-Preço ");
                    int x;
                    x = Convert.ToInt32(Console.ReadLine());

                    if (x == 1)
                    {
                        Console.Write("Novo genero do Jogo: ");
                        string Ngenero = Console.ReadLine();
                        cmd.Connection = conexao;
                        cmd.CommandText = String.Format(@"UPDATE Jogo
                                                  SET Genero = '{0}'
                                                  WHERE Nome = '{1}' And Plataforma = '{2}'; ", Ngenero, Nome, Plataforma);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        Console.WriteLine("Atualizado com sucesso");

                    }
                    else if (x == 2)
                    {
                        Console.Write("Novo Preço do Jogo: ");
                        int Preco = Convert.ToInt32(Console.ReadLine());
                        cmd.Connection = conexao;
                        cmd.CommandText = String.Format(@"UPDATE Jogo
                                                  SET Preco = {0}
                                                  WHERE Nome = '{1}' And Plataforma = '{2}'; ", Preco, Nome, Plataforma);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        Console.WriteLine("Atualizado com sucesso");
                    }
                }
                else
                    Console.WriteLine("Jogo Invalido");
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

    }
}
