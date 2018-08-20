using System;
using System.Windows.Forms;

namespace BankrekeningChallenge
{
    public partial class Bankzaken : Form
    {
        private readonly Bankrekening _bankrekeningEen;
        private readonly Bankrekening _bankrekeningTwee;


        public Bankzaken()
        {
            InitializeComponent();
            _bankrekeningEen = new Bankrekening("Duck, Dagobert");
            _bankrekeningTwee = new Bankrekening("Gans, Gijs");


            // Initializeer alle labels naar hun correcte waarden
            UpdateBankrekeningNumEenLabel.Text = _bankrekeningEen.Rekeningnummer().ToString();
            UpdateBankrekeningNumTweeLabel.Text = _bankrekeningTwee.Rekeningnummer().ToString();
            UpdateNaamEenLabel.Text = _bankrekeningEen.Naam();
            UpdateNaamTweeLabel.Text = _bankrekeningTwee.Naam();
            UpdateSaldoEenLabel.Text = _bankrekeningEen.Saldo().ToString("C");
            UpdateSaldoTweeLabel.Text = _bankrekeningTwee.Saldo().ToString("C");
        }

        private void StortenEenNaarTweeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Zet de texbox strings om in integers, maak van euros centen en tel beide integers bij elkaar op voor het totaal aantal centen.
                var stortBedrag = Convert.ToInt32(EurosEenTextBox.Text) * 100 + Convert.ToInt32(CentenEenTextBox.Text);
                _bankrekeningEen.MaakOver(_bankrekeningTwee, stortBedrag);
                UpdateLabels();
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
            }
        }

        private void StortenTweeNaarEenButton_Click(object sender, EventArgs e)
        {
            try
            {
                var stortBedrag = Convert.ToInt32(EurosTweeTextBox.Text) * 100 + Convert.ToInt32(CentenTweeTextBox.Text);
                _bankrekeningTwee.MaakOver(_bankrekeningEen, stortBedrag);
                UpdateLabels();
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
            }
        }

        private void OpnemenEenButton_Click(object sender, EventArgs e)
        {
            try
            {
                var bedrag = Convert.ToInt32(EurosEenTextBox.Text) * 100 + Convert.ToInt32(CentenEenTextBox.Text);
                _bankrekeningEen.NeemOp(bedrag);
                UpdateLabels();
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
            }
        }

        private void StortenEenButton_Click(object sender, EventArgs e)
        {
            try
            {
                var bedrag = Convert.ToInt32(EurosEenTextBox.Text) * 100 + Convert.ToInt32(CentenEenTextBox.Text);
                _bankrekeningEen.Stort(bedrag);
                UpdateLabels();
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
            }
        }

        private void OpnemenTweeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var bedrag = Convert.ToInt32(EurosTweeTextBox.Text) * 100 + Convert.ToInt32(CentenTweeTextBox.Text);
                _bankrekeningTwee.NeemOp(bedrag);
                UpdateLabels();
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
            }
        }

        private void StortenTweeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var bedrag = Convert.ToInt32(EurosTweeTextBox.Text) * 100 + Convert.ToInt32(CentenTweeTextBox.Text);
                _bankrekeningTwee.Stort(bedrag);
                UpdateLabels();
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message);
            }
        }

        private void UpdateLabels()
        {
            UpdateSaldoEenLabel.Text = ConvertToCents(_bankrekeningEen.Saldo()).ToString("C");
            UpdateSaldoTweeLabel.Text = ConvertToCents(_bankrekeningTwee.Saldo()).ToString("C");

            CentenEenTextBox.Text = "00";
            CentenTweeTextBox.Text = "00";
            EurosEenTextBox.Text = "00";
            EurosTweeTextBox.Text = "00";
        }

        private double ConvertToCents(double saldo)
        {
            return saldo / 100;
        }
    }
}