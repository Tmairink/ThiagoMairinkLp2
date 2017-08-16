using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Produtos
{
    class Produto
    {
        private int id;
        public int Id {
            get { return id; } 
        }

        public double Preco { get; set; }

        private int quantidade;
        public int Quantidade { get { return quantidade; } }

        public string Nome { get; set; }

        public Produto(int id,string Nome,double Preco)
        {
            this.id = id;
            this.Nome = Nome;
            this.Preco = Preco;
            this.quantidade = 0;
        }
        public void Reposicao(int Quantidade)
        {
           quantidade += Quantidade;
        }
        public void Retirada(int Quantidade)
        {
            if (Quantidade <= quantidade)
                quantidade -= Quantidade;
            else
                throw new Exception();
                
        }
        public string Imprimir()
        {
            return String.Format(" Id {0}, Nome {1}, Preço R${2:0.00}", Id , Nome, Preco);
        }

    }
}
