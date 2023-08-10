using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkUrunProjesi
{
    public partial class Frmana : Form
    {
        public Frmana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKategori frm = new FrmKategori();
            frm.Show();
        }

        private void btnurnişlm_Click(object sender, EventArgs e)
        {
            FrmUrun ur = new FrmUrun();
            ur.Show();
        }

        private void btnistişlm_Click(object sender, EventArgs e)
        {
            FrmIstatistik frm = new FrmIstatistik();
            frm.Show();
        }
    }
}
