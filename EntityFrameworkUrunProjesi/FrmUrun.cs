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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntmzle_Click(object sender, EventArgs e)
        {
            txtad.Text = " ";
            txtdurum.Text = " ";
            txtfiyat.Text = " ";
            txtid.Text = " ";
            txtmarka.Text = " ";
            txtstok.Text = " ";
            cmbktgr.Text = " ";

        }
        EntityFrmwrkUrunEntities ent = new EntityFrmwrkUrunEntities();
        private void btnlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in ent.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.TBLKATEGORI.AD,
                                            x.KATEGORI,
                                            x.FIYAT,
                                            x.STOK,
                                            x.DURUM

                                        }
                                       ).ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLURUN urn = new TBLURUN();
            urn.URUNAD = txtad.Text;
            urn.KATEGORI = int.Parse(cmbktgr.SelectedValue.ToString());
            urn.FIYAT = decimal.Parse(txtfiyat.Text);
            urn.STOK = short.Parse(txtstok.Text);
            urn.DURUM = true;
            urn.MARKA = txtmarka.Text;
            ent.TBLURUN.Add(urn);
            ent.SaveChanges();
            MessageBox.Show("Bilgileriniz Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(txtid.Text);
            var sil = ent.TBLURUN.Find(y);
            ent.TBLURUN.Remove(sil);
            ent.SaveChanges();
            MessageBox.Show("Bilgileriniz Silinmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btngunc_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(txtid.Text);
            var gunc = ent.TBLURUN.Find(y);
            gunc.URUNAD = txtad.Text;
            gunc.MARKA = txtmarka.Text;
            gunc.STOK = short.Parse(txtstok.Text);
            gunc.FIYAT = decimal.Parse(txtfiyat.Text);
            ent.SaveChanges();
            MessageBox.Show("Bilgileriniz Güncellenmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void btnesles_Click(object sender, EventArgs e)
        {
            txtid.Text = cmbktgr.SelectedValue.ToString();
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategori = (from x in ent.TBLKATEGORI
                            select new
                            {
                                x.ID,
                                x.AD
                            }
                        ).ToList();
            cmbktgr.ValueMember = "ID";
            cmbktgr.DisplayMember = "AD";
            cmbktgr.DataSource = kategori;
            cmbktgr.Text = " ";
        }
    }
}
