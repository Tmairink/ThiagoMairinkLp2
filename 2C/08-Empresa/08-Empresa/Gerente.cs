using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Gerente:Funcionario
    {
        private double bonus;

        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        private string setor;

        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }
        public Gerente(int id,string nome,string setor )
        {
            this.Id = id;
            this.Nome = nome;
            this.Setor = setor;
        }
        

        
    }
}
