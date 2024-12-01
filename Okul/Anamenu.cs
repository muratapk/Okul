using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul
{
    public partial class Anamenu : Form
    {
        public Anamenu()
        {
            InitializeComponent();
        }

        private void okulEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 okl = new Form1();
            okl.MdiParent = this;
            okl.Show();
        }
    }
}
