using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Funcionario
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int cpf;

        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        private double salario;

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
       
    }
}
