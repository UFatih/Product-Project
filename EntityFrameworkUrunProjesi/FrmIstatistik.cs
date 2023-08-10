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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        EntityFrmwrkUrunEntities ent = new EntityFrmwrkUrunEntities();

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            label13.Text = ent.TBLKATEGORI.Count().ToString();
            label14.Text = ent.TBLURUN.Count().ToString();
            label15.Text = ent.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            label16.Text = ent.TBLMUSTERI.Count(y => y.DURUM == false).ToString();
            label18.Text = ent.TBLURUN.Sum(y => y.STOK).ToString();
            label22.Text = ent.TBLURUN.Sum(y => y.FIYAT).ToString() + " TL";
            label19.Text = (from x in ent.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label20.Text = (from x in ent.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label17.Text = ent.TBLURUN.Count(x => x.KATEGORI == 2).ToString();
            label12.Text = ent.TBLURUN.Count(x => x.URUNAD == "GAMING LAPTOP").ToString();
            label21.Text = (from x in ent.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            label23.Text = ent.MARKAGETIR().FirstOrDefault();
        }
    }
}
