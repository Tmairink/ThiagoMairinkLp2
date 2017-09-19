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
        static double Kg;
        static double G;
        static double T;
        static double Lbs;
        static double valor;
        public static double KgParaG (double x)
        {
            valor = x;
            R= valor*1000;
            return R;
        }
        public static double KgParaT (double x)
        {
            valor = x;
            R= valor/1000;
            return R;
        }
        public static double KgParaLbs (double x)
        {
            valor = x;
            R = valor * 2.2046;
            return R;
        }
        public static double GParaKg(double x)
        {
            valor = x;
            R = valor /1000;
            return R;
        }
        public static double TParaKg(double x)
        {
            valor = x;
            R = valor * 1000;
            return R;
        }
        public static double LbsParaKg(double x)
        {
            valor = x;
            R = valor / 2.2046;
            return R;
        }

    }
}
