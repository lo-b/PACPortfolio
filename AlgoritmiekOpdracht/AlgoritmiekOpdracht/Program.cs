using System;

namespace AlgoritmiekOpdracht
{
    internal class Program
    {
        private string _input = "";

        private static void Main(string[] args)
        {
            var program = new Program();
            program.PromptUser();
        }

        /// <summary>
        ///     Methode die na gaat of het getal n (tussen 1 en 1000000) een priemgetal is.
        ///     Sinds we weten dat als n NIET priem is dat n = a*b (samengesteld getal).
        ///     Als a > sqrt(n) en b > sqrt(n) dan zou a*b > n, dus er geldt: a of b is kleiner of gelijk aan sqrt(n).
        ///     Hiermee kunnen we ons algoritme optimaliseren door alle getallen van 2 tot n-1 te beperken tot 2 tot sqrt(n).
        /// </summary>
        /// <param name="n">Integer n waarvan bepaald word of het een priemgetal is</param>
        /// <returns></returns>
        public string CheckPrime(int n)
        {
            // For-lus die van 2-wortel(n)
            for (var i = 2; i <= Math.Sqrt(n); i++)
                // Check of n te delen is door i ZONDER rest
                if (n % i == 0)
                    return "Het getal " + n + " is geen priemgetal";

            return "Het getal " + n + " is een priemgetal";
        }

        public void PromptUser()
        {
            while (true)
            {
                Console.WriteLine("Geef een getal tussen 1 en 1000000:");
                _input = Console.ReadLine();
                var n = Convert.ToInt32(_input);
                // Als de gebruiker een 0 invoert, stop het programma
                if (n == 0)
                {
                    break;
                }

                // Als de gebruiker een getal tussen de 1 en 1000000 invoert kijk of dit getal priem is
                if (n > 1 && n < 1000000)
                {
                    Console.WriteLine(CheckPrime(n));
                }
                else
                {
                    Console.WriteLine("Het getal is niet tussen de 1 en 1000000.");
                }
            }
        }
    }
}