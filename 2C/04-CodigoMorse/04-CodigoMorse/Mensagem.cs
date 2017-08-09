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
        public string retorno2;
        public string Som(string usuario)
        {
            for (int i = 0; i < usuario.Length; i++)
            {
                Console.Beep();
            }
            return retorno;
        }
        
        public string Morse(string usuario)
        {
           
            for (int i=0; i < usuario.Length; i++)
            {
                this.usuario = usuario;
                string[] tabela = new string[26] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", };
               

                
            }
            return retorno2;
            

        }   
        
    }
}
