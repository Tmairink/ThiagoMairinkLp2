using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CodigoMorse
{
    class Mensagem
    {
        public string usuario;
        public string retorno;
        public string[] tabela = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", };
        public string[] letra = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };


        public string Som(string usuario)
        {
            for (int i = 0; i < usuario.Length; i++)
            {
                Console.Beep(1000,2);
            }
            return retorno;
        }
        
        public string Morse(string usuario)
        {
            int i;
            string[] retorno2 = new string[usuario.Length - 1];
            for (i = 0; i < usuario.Length - 1; i++)
            {
                this.usuario = usuario;
                

                string x = Convert.ToString(usuario.Length - 1);
                if (x == letra[i])
                {
                    retorno2[i] = letra[i];

                }

                if (true)
                {
                    retorno2[i] = tabela[i];


                }


            }
            return retorno2[3];

        }

    }
}
