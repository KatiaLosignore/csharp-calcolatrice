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
            // return (int)Math.Abs(a);

            if (a < 0)
                return a + (a * -2);
            return a;

        }

        // Valore assoluto di un numero double

        public static double AbsoluteNumber(double a)
        {
            // return (double)Math.Abs(a);

            if (a < 0)
                return a + (a * -2);
            return a;
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


        /* BONUS
        Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente.
        Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi!
        (caso esponente = 0 e base = 0 anche se in matematica sarebbe un numero indefinito usiamo l’approccio informatico che lo calcola come 1)
        */

        public static int PowerExpo(int baseValue, int exponent)
        {
            if (baseValue == 0 && exponent == 0)
            {
                // Se base ed esponente sono entrambi zero, restituisco 1
                return 1;
            }
            else if (baseValue == 0)
            {
                // Se la base è zero, il risultato sarà sempre zero (tranne quando l'esponente è zero)
                return 0;
            }
            else if (exponent == 0)
            {
                // Qualsiasi numero elevato a 0 è 1
                return 1;
            }
            else if (exponent < 0)
            {
                // Se l'esponente è negativo, calcoliamo l'inverso della potenza positiva
                return (int)(1 / Math.Pow(baseValue, -exponent));
            }
            else
            {
                // elevamento a potenza positiva
                return (int)Math.Pow(baseValue, exponent);
            }
        }


    }
}


