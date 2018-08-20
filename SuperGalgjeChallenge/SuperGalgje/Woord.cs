using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperGalgje.Properties;

namespace SuperGalgje
{
    public class Woord
    {
        public readonly int AantalLetters;
        private string _word;

        public bool IsGoed(string woord)
        {
            return false;
        }

        public void SetWord(string word)
        {
            _word = word;
        }
        
    }
}
