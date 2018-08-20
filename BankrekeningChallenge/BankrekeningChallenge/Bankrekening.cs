using System;

namespace BankrekeningChallenge
{
    internal class Bankrekening
    {
        private static int volgendeVrijeRekeningnummer = 2001;
        private readonly string _naam;
        private readonly int _rekeningnummer;
        private int _saldo;

        public Bankrekening(string naam)
        {
            _naam = naam;
            _saldo = 0;
            _rekeningnummer = volgendeVrijeRekeningnummer;

            volgendeVrijeRekeningnummer++;
        }

        public Bankrekening(string naam, int saldo)
        {
            _naam = naam;
            _saldo = saldo;
            _rekeningnummer = volgendeVrijeRekeningnummer;

            volgendeVrijeRekeningnummer++;
        }

        // Getters
        public int Rekeningnummer()
        {
            return _rekeningnummer;
        }

        public string Naam()
        {
            return _naam;
        }

        public int Saldo()
        {
            return _saldo;
        }


        /// <summary>
        /// Methode om geld op te nemen.
        /// Als het bedrag positief is en als het bedrag niet groter is als het saldo is dan word het van de rekening afgeschreven.
        /// </summary>
        /// <param name="bedrag"> Het bedrag in centen dat de gebruiker op wil nemen. </param>
        public void NeemOp(int bedrag)
        {
            var nieuwSaldo = _saldo - bedrag;
            if (bedrag < 0)
                throw new ArgumentException("Negatief bedrag.");
            if (nieuwSaldo < 0)
                throw new ArgumentException("U probeert meer op te nemen dan uw saldo.");
            _saldo = nieuwSaldo;
        }


        /// <summary>
        /// Methode om geld te storten.
        /// Als het bedrag positief is dan word het bedrag op de rekening gestort.
        /// </summary>
        /// <param name="bedrag">Bedrag in centen om te storten </param>
        public void Stort(int bedrag)
        {
            if (bedrag < 0) throw new ArgumentException("Negatief bedrag.");

            _saldo += bedrag;
        }


        /// <summary>
        /// Methode om geld over te maken naar een andere rekening.
        /// Als het over te maken bedrag positief is en kleiner of gelijk is aan het saldo dan word het overgeschreven op de andere bankrekening.
        /// </summary>
        /// <param name="andereBankrekening">Bankrekening waar het geld gestort op moet worden.</param>
        /// <param name="bedrag">Te stortte bedrag in centen.</param>
        public void MaakOver(Bankrekening andereBankrekening, int bedrag)
        {
            var nieuwSaldo = _saldo - bedrag;
            if (bedrag < 0) throw new ArgumentException("Negatief bedrag.");

            if (nieuwSaldo < 0)
            {
                throw new ArgumentException("U probeert meer over te maken dan uw saldo.");
            }

            _saldo -= bedrag;
            andereBankrekening.Stort(bedrag);
        }
    }
}