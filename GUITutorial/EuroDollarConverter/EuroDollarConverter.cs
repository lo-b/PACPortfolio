using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroDollarConverter
{
    public partial class EuroDollarConverter : Form
    {

        public EuroDollarConverter()
        {
            InitializeComponent();
        }
   

        private void buttonEuroToDollar_Click(object sender, EventArgs e)
        {
            textBoxEuro.Text = Convert.ToString(DollarToEuro(Convert.ToDouble(textBoxDollar.Text), Convert.ToDouble(numericUpDownKoers.Value)));
        }

        private void buttonDollarToEuro_Click(object sender, EventArgs e)
        {
            textBoxDollar.Text = Convert.ToString(EuroToDollar(Convert.ToDouble(textBoxEuro.Text), Convert.ToDouble(numericUpDownKoers.Value)));

        }

        private double EuroToDollar(double amount, double rate)
        {
            return amount * rate;
        }

        private double DollarToEuro(double amount, double rate)
        {
            return amount / rate;
        }



    }
}
