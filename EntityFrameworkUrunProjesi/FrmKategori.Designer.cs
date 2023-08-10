
namespace EntityFrameworkUrunProjesi
{
    partial class FrmKategori
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngncle = new System.Windows.Forms.Button();
            this.txtkatid = new System.Windows.Forms.TextBox();
            this.txtkatad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btntmzle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(333, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnlistele.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistele.Location = new System.Drawing.Point(8, 119);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(126, 43);
            this.btnlistele.TabIndex = 1;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnsil.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(166, 119);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(126, 43);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnekle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(8, 181);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(126, 43);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btngncle
            // 
            this.btngncle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btngncle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngncle.Location = new System.Drawing.Point(166, 181);
            this.btngncle.Name = "btngncle";
            this.btngncle.Size = new System.Drawing.Size(126, 43);
            this.btngncle.TabIndex = 4;
            this.btngncle.Text = "Güncelle";
            this.btngncle.UseVisualStyleBackColor = false;
            this.btngncle.Click += new System.EventHandler(this.btngncle_Click);
            // 
            // txtkatid
            // 
            this.txtkatid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkatid.Location = new System.Drawing.Point(133, 21);
            this.txtkatid.Name = "txtkatid";
            this.txtkatid.Size = new System.Drawing.Size(172, 34);
            this.txtkatid.TabIndex = 5;
            // 
            // txtkatad
            // 
            this.txtkatad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkatad.Location = new System.Drawing.Point(133, 64);
            this.txtkatad.Name = "txtkatad";
            this.txtkatad.Size = new System.Drawing.Size(172, 34);
            this.txtkatad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kategori ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kategori AD:";
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncıkıs.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncıkıs.Location = new System.Drawing.Point(166, 243);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(126, 43);
            this.btncıkıs.TabIndex = 9;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btntmzle
            // 
            this.btntmzle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btntmzle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntmzle.Location = new System.Drawing.Point(8, 243);
            this.btntmzle.Name = "btntmzle";
            this.btntmzle.Size = new System.Drawing.Size(126, 43);
            this.btntmzle.TabIndex = 10;
            this.btntmzle.Text = "Temizle";
            this.btntmzle.UseVisualStyleBackColor = false;
            this.btntmzle.Click += new System.EventHandler(this.btntmzle_Click);
            // 
            // FrmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(691, 313);
            this.Controls.Add(this.btntmzle);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkatad);
            this.Controls.Add(this.txtkatid);
            this.Controls.Add(this.btngncle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FrmKategori";
            this.Text = "Kategoriler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btngncle;
        private System.Windows.Forms.TextBox txtkatid;
        private System.Windows.Forms.TextBox txtkatad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btntmzle;
    }
}

