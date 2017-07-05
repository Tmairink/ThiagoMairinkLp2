using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int a, b, c, d, e;
            string r = "XXX";
            
            
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                int QuestOK = 0, QuestIV = 0;
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                d = Convert.ToInt32(Console.ReadLine());
                e = Convert.ToInt32(Console.ReadLine());

                if(a<=100)
                {
                    r = "A";
                    QuestOK++;
                }
                else if(a<=155)
                {
                    QuestIV++;
                }
                if (b <= 100)
                {
                    r = "B";
                    QuestOK++;
                }
                else if (b<=155)
                {
                    QuestIV++;
                }
                if (c <= 100)
                {
                    r = "C";
                    QuestOK++;
                }
                else if (c <=155)
                {
                    QuestIV++;
                }
                if (d <= 100)
                {
                    r = "D";
                    QuestOK++;
                }
                else if (d <=155)
                {
                    QuestIV++;
                }
                if (e <= 100)
                {
                    r = "E";
                    QuestOK++;
                }
                else if (e <=155)
                {
                    QuestIV++;
                }

                if (QuestOK == 1 && QuestIV == 0)
                
                    Console.WriteLine(r);
                
                else

                    Console.WriteLine("*");
                
            }

        }
    }
}
