namespace HastaneYönetimiRandevuSistemi
{
    partial class FrmDoktorPaneli
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
            this.cmbDPaneliBrans = new System.Windows.Forms.ComboBox();
            this.mtxtDPaneliTC = new System.Windows.Forms.MaskedTextBox();
            this.txtDPaneliSifre = new System.Windows.Forms.TextBox();
            this.txtDPaneliSoyad = new System.Windows.Forms.TextBox();
            this.txtDPaneliAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDPaneliGuncelle = new System.Windows.Forms.Button();
            this.btnDPaneliSil = new System.Windows.Forms.Button();
            this.btnDPaneliEkle = new System.Windows.Forms.Button();
            this.dgvDPaneli = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDPaneli)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDPaneliBrans
            // 
            this.cmbDPaneliBrans.FormattingEnabled = true;
            this.cmbDPaneliBrans.Location = new System.Drawing.Point(148, 181);
            this.cmbDPaneliBrans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDPaneliBrans.Name = "cmbDPaneliBrans";
            this.cmbDPaneliBrans.Size = new System.Drawing.Size(208, 24);
            this.cmbDPaneliBrans.TabIndex = 39;
            // 
            // mtxtDPaneliTC
            // 
            this.mtxtDPaneliTC.Location = new System.Drawing.Point(148, 149);
            this.mtxtDPaneliTC.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtDPaneliTC.Mask = "00000000000";
            this.mtxtDPaneliTC.Name = "mtxtDPaneliTC";
            this.mtxtDPaneliTC.Size = new System.Drawing.Size(208, 22);
            this.mtxtDPaneliTC.TabIndex = 37;
            this.mtxtDPaneliTC.ValidatingType = typeof(int);
            // 
            // txtDPaneliSifre
            // 
            this.txtDPaneliSifre.Location = new System.Drawing.Point(148, 214);
            this.txtDPaneliSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtDPaneliSifre.Name = "txtDPaneliSifre";
            this.txtDPaneliSifre.Size = new System.Drawing.Size(208, 22);
            this.txtDPaneliSifre.TabIndex = 36;
            // 
            // txtDPaneliSoyad
            // 
            this.txtDPaneliSoyad.Location = new System.Drawing.Point(148, 117);
            this.txtDPaneliSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtDPaneliSoyad.Name = "txtDPaneliSoyad";
            this.txtDPaneliSoyad.Size = new System.Drawing.Size(208, 22);
            this.txtDPaneliSoyad.TabIndex = 35;
            // 
            // txtDPaneliAd
            // 
            this.txtDPaneliAd.Location = new System.Drawing.Point(148, 85);
            this.txtDPaneliAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDPaneliAd.Name = "txtDPaneliAd";
            this.txtDPaneliAd.Size = new System.Drawing.Size(208, 22);
            this.txtDPaneliAd.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(85, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Şifre: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(77, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Branş: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(22, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "TC Kimlik No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(73, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Soyad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(105, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ad:";
            // 
            // btnDPaneliGuncelle
            // 
            this.btnDPaneliGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnDPaneliGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDPaneliGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDPaneliGuncelle.Location = new System.Drawing.Point(148, 305);
            this.btnDPaneliGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDPaneliGuncelle.Name = "btnDPaneliGuncelle";
            this.btnDPaneliGuncelle.Size = new System.Drawing.Size(209, 39);
            this.btnDPaneliGuncelle.TabIndex = 42;
            this.btnDPaneliGuncelle.Text = "Güncelle";
            this.btnDPaneliGuncelle.UseVisualStyleBackColor = false;
            this.btnDPaneliGuncelle.Click += new System.EventHandler(this.btnDPaneliGuncelle_Click);
            // 
            // btnDPaneliSil
            // 
            this.btnDPaneliSil.BackColor = System.Drawing.Color.Teal;
            this.btnDPaneliSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDPaneliSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDPaneliSil.Location = new System.Drawing.Point(261, 258);
            this.btnDPaneliSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnDPaneliSil.Name = "btnDPaneliSil";
            this.btnDPaneliSil.Size = new System.Drawing.Size(96, 39);
            this.btnDPaneliSil.TabIndex = 41;
            this.btnDPaneliSil.Text = "Sil";
            this.btnDPaneliSil.UseVisualStyleBackColor = false;
            this.btnDPaneliSil.Click += new System.EventHandler(this.btnDPaneliSil_Click);
            // 
            // btnDPaneliEkle
            // 
            this.btnDPaneliEkle.BackColor = System.Drawing.Color.Teal;
            this.btnDPaneliEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDPaneliEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDPaneliEkle.Location = new System.Drawing.Point(148, 258);
            this.btnDPaneliEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDPaneliEkle.Name = "btnDPaneliEkle";
            this.btnDPaneliEkle.Size = new System.Drawing.Size(96, 39);
            this.btnDPaneliEkle.TabIndex = 40;
            this.btnDPaneliEkle.Text = "Ekle";
            this.btnDPaneliEkle.UseVisualStyleBackColor = false;
            this.btnDPaneliEkle.Click += new System.EventHandler(this.btnDPaneliEkle_Click);
            // 
            // dgvDPaneli
            // 
            this.dgvDPaneli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDPaneli.Location = new System.Drawing.Point(404, 85);
            this.dgvDPaneli.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDPaneli.Name = "dgvDPaneli";
            this.dgvDPaneli.Size = new System.Drawing.Size(607, 260);
            this.dgvDPaneli.TabIndex = 43;
            this.dgvDPaneli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDPaneli_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(452, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Doktor Paneli";
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1037, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDPaneli);
            this.Controls.Add(this.btnDPaneliGuncelle);
            this.Controls.Add(this.btnDPaneliSil);
            this.Controls.Add(this.btnDPaneliEkle);
            this.Controls.Add(this.cmbDPaneliBrans);
            this.Controls.Add(this.mtxtDPaneliTC);
            this.Controls.Add(this.txtDPaneliSifre);
            this.Controls.Add(this.txtDPaneliSoyad);
            this.Controls.Add(this.txtDPaneliAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoktorPaneli";
            this.Text = "FrmDoktorPaneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDPaneli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDPaneliBrans;
        private System.Windows.Forms.MaskedTextBox mtxtDPaneliTC;
        private System.Windows.Forms.TextBox txtDPaneliSifre;
        private System.Windows.Forms.TextBox txtDPaneliSoyad;
        private System.Windows.Forms.TextBox txtDPaneliAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDPaneliGuncelle;
        private System.Windows.Forms.Button btnDPaneliSil;
        private System.Windows.Forms.Button btnDPaneliEkle;
        private System.Windows.Forms.DataGridView dgvDPaneli;
        private System.Windows.Forms.Label label1;
    }
}