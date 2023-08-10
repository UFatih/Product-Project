
namespace EntityFrameworkUrunProjesi
{
    partial class Frmana
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
            this.btnkatişlm = new System.Windows.Forms.Button();
            this.btnistişlm = new System.Windows.Forms.Button();
            this.btnurnişlm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkatişlm
            // 
            this.btnkatişlm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnkatişlm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkatişlm.Location = new System.Drawing.Point(12, 12);
            this.btnkatişlm.Name = "btnkatişlm";
            this.btnkatişlm.Size = new System.Drawing.Size(249, 148);
            this.btnkatişlm.TabIndex = 0;
            this.btnkatişlm.Text = "KATEGORI ISLEMLERI";
            this.btnkatişlm.UseVisualStyleBackColor = false;
            this.btnkatişlm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnistişlm
            // 
            this.btnistişlm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnistişlm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnistişlm.Location = new System.Drawing.Point(522, 14);
            this.btnistişlm.Name = "btnistişlm";
            this.btnistişlm.Size = new System.Drawing.Size(249, 146);
            this.btnistişlm.TabIndex = 1;
            this.btnistişlm.Text = "ISTATISTIK";
            this.btnistişlm.UseVisualStyleBackColor = false;
            this.btnistişlm.Click += new System.EventHandler(this.btnistişlm_Click);
            // 
            // btnurnişlm
            // 
            this.btnurnişlm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnurnişlm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnurnişlm.Location = new System.Drawing.Point(267, 14);
            this.btnurnişlm.Name = "btnurnişlm";
            this.btnurnişlm.Size = new System.Drawing.Size(249, 146);
            this.btnurnişlm.TabIndex = 2;
            this.btnurnişlm.Text = "URUN ISLEMLERI";
            this.btnurnişlm.UseVisualStyleBackColor = false;
            this.btnurnişlm.Click += new System.EventHandler(this.btnurnişlm_Click);
            // 
            // Frmana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(776, 172);
            this.Controls.Add(this.btnurnişlm);
            this.Controls.Add(this.btnistişlm);
            this.Controls.Add(this.btnkatişlm);
            this.MaximizeBox = false;
            this.Name = "Frmana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkatişlm;
        private System.Windows.Forms.Button btnistişlm;
        private System.Windows.Forms.Button btnurnişlm;
    }
}