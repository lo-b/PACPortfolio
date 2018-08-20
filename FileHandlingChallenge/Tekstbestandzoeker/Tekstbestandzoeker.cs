using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekstbestandzoeker
{
    public partial class Tekstbestandzoeker : Form
    {
        private Zoeker zoeker = new Zoeker();

        public Tekstbestandzoeker()
        {
            InitializeComponent();
            var directories = zoeker.GetDirectories();
            foreach (var directory in directories)
            {
                listBox1.Items.Add(directory);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var files = zoeker.GetTextFiles(listBox1.SelectedItem.ToString());
            foreach (var file in files)
            {
                var filename = Path.GetFileName(file);
                if (!filename.ToLower().StartsWith("a"))
                {
                    listBox2.Items.Add(filename);
                }
            }
        }
    }
}
