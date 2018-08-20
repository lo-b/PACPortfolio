using System;

namespace BasisOpdracht
{
    internal class Program
    {
        // Methode om faculteit te berekenen
        // Invoer: n
        // Resultaat: faculteit van n
        // Voorwaarde: n >= 0

        // Sinds de faculteit recursief is gedefinieerd leek het mij toepaselijk om dit ook
        // zo te programmeren.
        // Recursieve methodes bestaan uit een (of meerdere) base case(s) en een step case die het probleem opsplitst
        // om uiteindelijk bij de base case te komen.

        private static long Faculteit(int n)
        {
            // base case !0 = 1
            if (n == 0)
            {
                return 1;
            }
            // Maak het probleem kleiner, werkend naar de base case
            else
            {
                return n * Faculteit(n - 1);
            }
        }


        // Hieronder is een berekening in for-loop variant mocht dit wenselijk zijn.

        /*private static long Faculteit(int n)

        {
            long fac = 1;
            // For-loop om de faculteit "achterstevoren" te berekenen
            // We initialiseren fac = 1 iteratief vermedigvuldigen we het resultaat (fac) met i wat
            // van 2 tot en met n gaat.
            for (int i = 2; i <= n; i++)
            {
                fac *= i;
            }
            return fac;
        }*/

        private static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal: ");
            var userInput = Console.ReadLine();
            var userInputToNum = int.Parse(userInput);
            Console.WriteLine(string.Format("{0}! = {1}", userInputToNum, Faculteit(userInputToNum)));
        }
    }
}