using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Woordplakker
{
    public partial class Woordplakker : Form
    {
        public Woordplakker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            try
            {
                string woord = textBoxWoord.Text;
                int aantal = Convert.ToInt32(textBoxAantal.Text);

                MessageBox.Show(Plak(woord, aantal));
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Voer een cijfer in bij 'Aantal'.");
            }


        }

        private string Plak(string woord, int aantal)
        {
            // Get word from textBox
            StringBuilder stringBuilder = new StringBuilder();


            // Append the word to the builder for amount of times that the user decides
            for (int i = 0; i < aantal; i++)
            {
                stringBuilder.Append(woord);
            }

            return stringBuilder.ToString();
        }
    }
}
