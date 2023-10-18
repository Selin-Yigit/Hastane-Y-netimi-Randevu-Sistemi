namespace HastaneYönetimiRandevuSistemi
{
    partial class FrmDoktorGuncelle
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
            this.btnDGüncelle = new System.Windows.Forms.Button();
            this.mtxtDGüncelleTC = new System.Windows.Forms.MaskedTextBox();
            this.txtDGüncelleSifre = new System.Windows.Forms.TextBox();
            this.txtDGüncelleSoyad = new System.Windows.Forms.TextBox();
            this.txtDGüncelleAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDGüncelleBrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDGüncelle
            // 
            this.btnDGüncelle.BackColor = System.Drawing.Color.Teal;
            this.btnDGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDGüncelle.Location = new System.Drawing.Point(160, 266);
            this.btnDGüncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDGüncelle.Name = "btnDGüncelle";
            this.btnDGüncelle.Size = new System.Drawing.Size(160, 39);
            this.btnDGüncelle.TabIndex = 27;
            this.btnDGüncelle.Text = "Güncelle";
            this.btnDGüncelle.UseVisualStyleBackColor = false;
            this.btnDGüncelle.Click += new System.EventHandler(this.btnDGüncelle_Click);
            // 
            // mtxtDGüncelleTC
            // 
            this.mtxtDGüncelleTC.Location = new System.Drawing.Point(160, 156);
            this.mtxtDGüncelleTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtDGüncelleTC.Mask = "00000000000";
            this.mtxtDGüncelleTC.Name = "mtxtDGüncelleTC";
            this.mtxtDGüncelleTC.Size = new System.Drawing.Size(159, 22);
            this.mtxtDGüncelleTC.TabIndex = 25;
            this.mtxtDGüncelleTC.ValidatingType = typeof(int);
            // 
            // txtDGüncelleSifre
            // 
            this.txtDGüncelleSifre.Location = new System.Drawing.Point(160, 222);
            this.txtDGüncelleSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDGüncelleSifre.Name = "txtDGüncelleSifre";
            this.txtDGüncelleSifre.Size = new System.Drawing.Size(159, 22);
            this.txtDGüncelleSifre.TabIndex = 24;
            // 
            // txtDGüncelleSoyad
            // 
            this.txtDGüncelleSoyad.Location = new System.Drawing.Point(160, 124);
            this.txtDGüncelleSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDGüncelleSoyad.Name = "txtDGüncelleSoyad";
            this.txtDGüncelleSoyad.Size = new System.Drawing.Size(159, 22);
            this.txtDGüncelleSoyad.TabIndex = 22;
            // 
            // txtDGüncelleAd
            // 
            this.txtDGüncelleAd.Location = new System.Drawing.Point(160, 92);
            this.txtDGüncelleAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDGüncelleAd.Name = "txtDGüncelleAd";
            this.txtDGüncelleAd.Size = new System.Drawing.Size(159, 22);
            this.txtDGüncelleAd.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(97, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Şifre: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(89, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Branş: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "TC Kimlik No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(85, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Soyad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(117, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Doktor Bilgilerini Güncelle";
            // 
            // cmbDGüncelleBrans
            // 
            this.cmbDGüncelleBrans.FormattingEnabled = true;
            this.cmbDGüncelleBrans.Location = new System.Drawing.Point(160, 188);
            this.cmbDGüncelleBrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDGüncelleBrans.Name = "cmbDGüncelleBrans";
            this.cmbDGüncelleBrans.Size = new System.Drawing.Size(159, 24);
            this.cmbDGüncelleBrans.TabIndex = 28;
            // 
            // FrmDoktorGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(407, 335);
            this.Controls.Add(this.cmbDGüncelleBrans);
            this.Controls.Add(this.btnDGüncelle);
            this.Controls.Add(this.mtxtDGüncelleTC);
            this.Controls.Add(this.txtDGüncelleSifre);
            this.Controls.Add(this.txtDGüncelleSoyad);
            this.Controls.Add(this.txtDGüncelleAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDoktorGuncelle";
            this.Text = "FrmDoktorGuncelle";
            this.Load += new System.EventHandler(this.FrmDoktorGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDGüncelle;
        private System.Windows.Forms.MaskedTextBox mtxtDGüncelleTC;
        private System.Windows.Forms.TextBox txtDGüncelleSifre;
        private System.Windows.Forms.TextBox txtDGüncelleSoyad;
        private System.Windows.Forms.TextBox txtDGüncelleAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDGüncelleBrans;
    }
}