using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperGalgje.Properties;

namespace SuperGalgje
{
    public class SpelStatus
    {
        public Woord HetWoord { get; set; }
        private StringBuilder geradenletters = new StringBuilder();
        public List<string> _words = new List<string>();

        public void ReadFile()
        {
            FileStream fs = new FileStream(@"..\..\Resources\aThousandEnglishWords.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string regel = reader.ReadLine();
            while (regel != null)
            {
                _words.Add(regel);
                regel = reader.ReadLine();
            }
            reader.Close();
            fs.Close();
        }

        




    }
}
