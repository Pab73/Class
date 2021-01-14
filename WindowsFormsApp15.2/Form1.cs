using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15._2
{
    public partial class Form1 : Form
    {
        string startValueString = "Kanaal: 0 - Volume: 0 ";
        public Form1()
        {
            InitializeComponent();
            labelResultaat.Text = startValueString;
        }

        TV tv = new TV();

        private void btnVermeerder_Click(object sender, EventArgs e)
        {
            tv.VermeerderKanaal();
            tv.VermeerderVolume();
            labelResultaat.Text = tv.ToonGegevens();
        }

        private void btnVerminder_Click(object sender, EventArgs e)
        {
            tv.VerminderKanaal();
            tv.VerminderVolume();
            labelResultaat.Text = tv.ToonGegevens();
        }
    }
}
