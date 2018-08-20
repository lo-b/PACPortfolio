using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haxor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHaxor_Click(object sender, EventArgs e)
        {
            StringBuilder input = new StringBuilder(textBoxUserInput.Text);

            // replace occurences in SB with Haxor Notation:
            input.Replace("a", "4");
            input.Replace("s", "5");
            input.Replace("e", "3");
            input.Replace("v", @"\/");
            input.Replace("V", @"\/");
            input.Replace("m", @"|V|");

            labelOutput.Text = input.ToString();
        }
    }
}
