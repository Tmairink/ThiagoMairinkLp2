using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Tercerizado :Empregado
    {

        private string EmpresaMatriz;

        public string EmpresaMatriz1
        {
            get { return EmpresaMatriz; }
            set { EmpresaMatriz = value; }
        }
        
        public Tercerizado(int id,string nome,int dtentrada )
        {
            this.Id = id;
            this.Nome = nome;
            this.Dtentrada = dtentrada;
        }
    }
}
