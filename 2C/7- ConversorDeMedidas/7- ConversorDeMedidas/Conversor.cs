using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__ConversorDeMedidas
{
    static class Conversor
    {
        static double R;
        public static double KgParaG(double x)
        {
            R = x * 1000;
            return R;
        }
        public static double KgParaT(double x)
        {
            R = x / 1000;
            return R;
        }
        public static double KgParaLbs(double x)
        {
            R = x * 2.2046;
            return R;
        }
        public static double GParaKg(double x)
        {
            R = x / 1000;
            return R;
        }
        public static double TParaKg(double x)
        {
            
            R = x * 1000;
            return R;
        }
        public static double LbsParaKg(double x)
        {
            
            R = x / 2.2046;
            return R;
        }

        public static double CParaF(double x)
        {
            R = ((x - 32) / 9) * 5;
            return R;
        }
        public static double CParaK(double x)
        {
            R = x + 273;
            return R;
        }
        public static double FParaK(double x)
        {
            R = (x + 459) * 5 / 9;
            return R;
        }
        public static double FParaC(double x)
        {
            R = (x - 32) * 5 / 9;
            return R;
        }
        public static double KParaF(double x)
        {
            R = x * 9 / 5 - 459;
            return R;
        }
        public static double KParaC(double x)
        {
            R = x - 273;
            return R;
        }
        public static double MParaKm(double x)
        {
            R = x / 1000;
            return R;
        }
        public static double KmParaM(double x)
        {
            R = x * 1000;
            return R;
        }
        public static double KmParaMilha(double x)
        {
            R = x / 0.62;
            return R;
        }
        public static double MilhaParaKm(double x)
        {
            R = x * 0.62;
            return R;
        }
        public static double MParaPes(double x)
        {
            R = x * 3.28;
            return R;
        }
        public static double PesParaM(double x)
        {
            R = x / 3.28;
            return R;
        }
        public static double MParaPol(double x)
        {
            R = x * 39.37;
            return R;
        }
        public static double PolParaM(double x)
        {
            R = x / 39.37;
            return R;
        }
        public static double PolParaPes(double x)
        {
            R = x * 12 ;
            return R;
        }
        public static double PesParaPol(double x)
        {
            R = x / 12;
            return R;
        }

    }
}