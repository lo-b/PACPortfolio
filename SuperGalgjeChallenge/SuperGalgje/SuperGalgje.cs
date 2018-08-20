using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperGalgje.Properties;

namespace SuperGalgje
{
    public partial class SuperGalgje : Form
    {
        SpelStatus spelStatus = new SpelStatus();
        StringBuilder sb = new StringBuilder();
        Random rng = new Random();
        public SuperGalgje()
        {
            InitializeComponent();
            
        }
    }
}
