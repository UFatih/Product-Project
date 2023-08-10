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
    public partial class Admingiris : Form
    {
        public Admingiris()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            EntityFrmwrkUrunEntities ent = new EntityFrmwrkUrunEntities();
            var getir = from x in ent.TBLADMIN where x.KULLANICI == txtkulad.Text && x.SIFRE == txtsifre.Text select x;
            if (getir.Any())
            {
                Frmana frm = new Frmana();
                frm.Show();

            }

            else
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}