using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstbestandzoeker
{
    public class Zoeker
    {
        private readonly string root = Path.GetPathRoot(Directory.GetCurrentDirectory());
        public List<string> GetDirectories()
        {
            List<string> directoryList = new List<string>();
            var directories = Directory.GetDirectories(root);
            foreach (var directory in directories)
            {
                directoryList.Add(directory);
            }

            return directoryList;
        }

        public List<string> GetTextFiles(string directoryPath)
        {

            List<string> filesList = new List<string>();

            var files = Directory.EnumerateFiles(directoryPath, "*.txt");

            foreach (var file in files)
            {
                filesList.Add(file);
            }

            return filesList;
        }
    }
}
