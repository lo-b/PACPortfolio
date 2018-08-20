using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstverwerker
{
    class Verwerker
    {
        private string _fileName = "";
        public void SetFileName(string fileName)
        {
            _fileName = fileName;
        }

        public string Read()
        {
            return File.ReadAllText(_fileName);
        }

        public void Write(string editedFile)
        {

            File.WriteAllText(_fileName, editedFile);
        }
    }
}
