using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        // Polimorfismo - Overload dei metodi


        // Somma di due numeri interi
        public static int SumNumber(int a, int b)
        {
            return a + b;
        }

        // Somma di due numeri double
        public static double SumNumber(double a, double b)
        {
            return a + b;
        }

        // Differenza tra due numeri interi
        public static int SubNumber(int a, int b)
        {
            return a - b;
        }

        // Differenza tra due numeri double
        public static double SubNumber(double a, double b)
        {
            return a - b;
        }

        // Moltiplicazione di due numeri interi
        public static int MultiNumber(int a, int b)
        {
            return a * b;
        }

        // Moltiplicazione di due numeri double
        public static double MultiNumber(double a, double b)
        {
            return a * b;
        }

        // Valore assoluto di un numero intero

        public static int AbsoluteNumber(int a)
        {
            return (int)Math.Abs(a);
        }

        // Valore assoluto di un numero double

        public static double AbsoluteNumber(double a)
        {
            return (double)Math.Abs(a);
        }

        // Minimo tra due numeri interi

        public static int MinNumber(int a, int b)
        {
            return Math.Min(a, b);
        }

        // Minimo tra due numeri double

        public static double MinNumber(double a, double b)
        {
            return Math.Min(a, b);
        }

        // Massimo tra due numeri interi

        public static int MaxNumber(int a, int b)
        {
            return Math.Max(a, b);
        }

        // Massimo tra due numeri double
        public static double MaxNumber(double a, double b)
        {
            return Math.Max(a, b);
        }

    }
}
