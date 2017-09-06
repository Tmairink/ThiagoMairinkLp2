using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Empregado:Funcionario
    {
        private Gerente chefe;

        public Gerente Chefe
        {
            get { return chefe; }
            set { chefe = value; }
        }
        private int dtentrada;

        public int Dtentrada
        {
            get { return dtentrada; }
            set { dtentrada = value; }
        }
        public Empregado(int id,string nome,string Chefe,int dtentrada )
        {
            this.Id = id;
            this.Nome = nome;
            this.Chefe = chefe;
            this.Dtentrada = dtentrada;
        }
       
    }
}
