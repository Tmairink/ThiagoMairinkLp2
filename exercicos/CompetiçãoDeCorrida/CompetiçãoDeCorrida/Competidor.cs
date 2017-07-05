using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetiçãoDeCorrida
{
    class Competidor
    {
        public string Nome;
        public double Tempo1;
        public double Tempo2;
        public double Tempo3;
       

         public double CalcularTempo()

          {
                 double TempOfi = 0;

            if (Tempo1 > Tempo2 && Tempo1 > Tempo3)
              {
                  TempOfi = Tempo2 + Tempo3;
              }

              else if (Tempo2 > Tempo3)
              {
                  TempOfi = Tempo1 + Tempo3;
              }

              else

                  TempOfi = Tempo1 + Tempo2;

            return TempOfi;
          }


   }

   



   

}
