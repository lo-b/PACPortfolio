using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloJij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowMsgBox_Click(object sender, EventArgs e)
        {
            var input = textBoxUserInput.Text;
            var nameStartIndex = input.IndexOf(" ") + 1;
            var stringBuilder = new StringBuilder();
            var lastName = input.Substring(nameStartIndex);

            if (radioButtonMan.Checked)
            {
                stringBuilder.Append("Hallo mijnheer " + lastName);
            }

            if (radioButtonVrouw.Checked)
            {
                stringBuilder.Append("Hallo mejuffrouw " + lastName);
            }

            MessageBox.Show(stringBuilder.ToString());


        }
    }
}
