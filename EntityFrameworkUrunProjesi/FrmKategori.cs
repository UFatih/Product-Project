using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace EntityFrameworkUrunProjesi
{
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        EntityFrmwrkUrunEntities ent = new EntityFrmwrkUrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            var Kategori = ent.TBLKATEGORI.ToList();
            dataGridView1.DataSource = Kategori;
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI kat = new TBLKATEGORI();
            kat.AD = txtkatad.Text;
            ent.TBLKATEGORI.Add(kat);
            ent.SaveChanges();
            MessageBox.Show("Bilgileriniz Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            
            int y = Convert.ToInt32(txtkatid.Text);
            var ktg = ent.TBLKATEGORI.Find(y);
            ent.TBLKATEGORI.Remove(ktg);
            ent.SaveChanges();
            MessageBox.Show("Bilgileriniz Silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btngncle_Click(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(txtkatid.Text);
            var kt = ent.TBLKATEGORI.Find(x);
            kt.AD = txtkatad.Text;
            ent.SaveChanges();
            MessageBox.Show("Bilgileriniz Güncellenmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btntmzle_Click(object sender, EventArgs e)
        {
            txtkatad.Text = " ";
            txtkatid.Text = " ";
        }
    }
}
