
namespace EntityFrameworkUrunProjesi
{
    partial class FrmUrun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlist = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngunc = new System.Windows.Forms.Button();
            this.btntmzle = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.cmbktgr = new System.Windows.Forms.ComboBox();
            this.btnesles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(138, 9);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(216, 34);
            this.txtid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Durum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(50, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kategori:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 305);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.Linen;
            this.btnlist.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlist.Location = new System.Drawing.Point(12, 294);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(165, 55);
            this.btnlist.TabIndex = 16;
            this.btnlist.Text = "Listele";
            this.btnlist.UseVisualStyleBackColor = false;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Linen;
            this.btnekle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(189, 294);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(165, 55);
            this.btnekle.TabIndex = 17;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Linen;
            this.btnsil.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(12, 363);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(165, 55);
            this.btnsil.TabIndex = 18;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngunc
            // 
            this.btngunc.BackColor = System.Drawing.Color.Linen;
            this.btngunc.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngunc.Location = new System.Drawing.Point(189, 363);
            this.btngunc.Name = "btngunc";
            this.btngunc.Size = new System.Drawing.Size(165, 55);
            this.btngunc.TabIndex = 19;
            this.btngunc.Text = "Güncelle";
            this.btngunc.UseVisualStyleBackColor = false;
            this.btngunc.Click += new System.EventHandler(this.btngunc_Click);
            // 
            // btntmzle
            // 
            this.btntmzle.BackColor = System.Drawing.Color.Linen;
            this.btntmzle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntmzle.Location = new System.Drawing.Point(743, 342);
            this.btntmzle.Name = "btntmzle";
            this.btntmzle.Size = new System.Drawing.Size(165, 62);
            this.btntmzle.TabIndex = 20;
            this.btntmzle.Text = "Temizle";
            this.btntmzle.UseVisualStyleBackColor = false;
            this.btntmzle.Click += new System.EventHandler(this.btntmzle_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.Linen;
            this.btncıkıs.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncıkıs.Location = new System.Drawing.Point(563, 342);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(165, 62);
            this.btncıkıs.TabIndex = 21;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(138, 47);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(216, 34);
            this.txtad.TabIndex = 22;
            // 
            // txtmarka
            // 
            this.txtmarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmarka.Location = new System.Drawing.Point(138, 84);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(216, 34);
            this.txtmarka.TabIndex = 23;
            // 
            // txtstok
            // 
            this.txtstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtstok.Location = new System.Drawing.Point(138, 121);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(216, 34);
            this.txtstok.TabIndex = 24;
            // 
            // txtdurum
            // 
            this.txtdurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdurum.Location = new System.Drawing.Point(138, 158);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(216, 34);
            this.txtdurum.TabIndex = 25;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfiyat.Location = new System.Drawing.Point(138, 196);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(216, 34);
            this.txtfiyat.TabIndex = 26;
            // 
            // cmbktgr
            // 
            this.cmbktgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbktgr.FormattingEnabled = true;
            this.cmbktgr.Location = new System.Drawing.Point(138, 236);
            this.cmbktgr.Name = "cmbktgr";
            this.cmbktgr.Size = new System.Drawing.Size(216, 37);
            this.cmbktgr.TabIndex = 27;
            // 
            // btnesles
            // 
            this.btnesles.BackColor = System.Drawing.Color.Linen;
            this.btnesles.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnesles.Location = new System.Drawing.Point(380, 342);
            this.btnesles.Name = "btnesles";
            this.btnesles.Size = new System.Drawing.Size(165, 62);
            this.btnesles.TabIndex = 28;
            this.btnesles.Text = "Kategori Eşleştirme";
            this.btnesles.UseVisualStyleBackColor = false;
            this.btnesles.Click += new System.EventHandler(this.btnesles_Click);
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1167, 430);
            this.Controls.Add(this.btnesles);
            this.Controls.Add(this.cmbktgr);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btntmzle);
            this.Controls.Add(this.btngunc);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.MaximizeBox = false;
            this.Name = "FrmUrun";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngunc;
        private System.Windows.Forms.Button btntmzle;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.ComboBox cmbktgr;
        private System.Windows.Forms.Button btnesles;
    }
}