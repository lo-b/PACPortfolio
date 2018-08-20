using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekstverwerker
{
    public partial class Tekstverwerker : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        Verwerker verwerker = new Verwerker();
        public Tekstverwerker()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            // Filter dat de gebruiker alleen bestanden met de extensie .txt te zien krijgt.
            ofd.Filter = "Tekstbestanden (*.txt)|*txt";
            // Voer de code alleen uit als de gebruiker daadwerkelijk een bestand geselecteerd heeft
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Bepaal de path van de file die is geopend en laat de inhoud zien
                verwerker.SetFileName(ofd.FileName);
                FileTextBox.Text = verwerker.Read();
            }

        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            // Schrijf de nieuwe inhoud naar de file
            verwerker.Write(FileTextBox.Text);
        }
    }
}






