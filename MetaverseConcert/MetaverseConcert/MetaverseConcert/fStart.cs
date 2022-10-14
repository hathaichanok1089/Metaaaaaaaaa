using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaverseConcert
{
    public partial class fStart : Form
    {
        public fStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fRegister fr = new fRegister();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fLogin fl = new fLogin();
            fl.Show();
        }
    }
}
