namespace HastaneYönetimiRandevuSistemi
{
    partial class FrmHastaGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHGirisSifre = new System.Windows.Forms.TextBox();
            this.mtxtHGirisTc = new System.Windows.Forms.MaskedTextBox();
            this.lnkHGirisKayıt = new System.Windows.Forms.LinkLabel();
            this.btnHGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No: ";
            // 
            // txtHGirisSifre
            // 
            this.txtHGirisSifre.Location = new System.Drawing.Point(133, 103);
            this.txtHGirisSifre.Name = "txtHGirisSifre";
            this.txtHGirisSifre.Size = new System.Drawing.Size(143, 20);
            this.txtHGirisSifre.TabIndex = 2;
            this.txtHGirisSifre.UseSystemPasswordChar = true;
            // 
            // mtxtHGirisTc
            // 
            this.mtxtHGirisTc.Location = new System.Drawing.Point(133, 77);
            this.mtxtHGirisTc.Mask = "00000000000";
            this.mtxtHGirisTc.Name = "mtxtHGirisTc";
            this.mtxtHGirisTc.Size = new System.Drawing.Size(143, 20);
            this.mtxtHGirisTc.TabIndex = 1;
            this.mtxtHGirisTc.ValidatingType = typeof(int);
            // 
            // lnkHGirisKayıt
            // 
            this.lnkHGirisKayıt.AutoSize = true;
            this.lnkHGirisKayıt.Location = new System.Drawing.Point(170, 189);
            this.lnkHGirisKayıt.Name = "lnkHGirisKayıt";
            this.lnkHGirisKayıt.Size = new System.Drawing.Size(51, 13);
            this.lnkHGirisKayıt.TabIndex = 5;
            this.lnkHGirisKayıt.TabStop = true;
            this.lnkHGirisKayıt.Text = "Kayıt Ol";
            this.lnkHGirisKayıt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHGirisKayıt_LinkClicked);
            // 
            // btnHGiris
            // 
            this.btnHGiris.BackColor = System.Drawing.Color.Teal;
            this.btnHGiris.Location = new System.Drawing.Point(133, 139);
            this.btnHGiris.Name = "btnHGiris";
            this.btnHGiris.Size = new System.Drawing.Size(143, 35);
            this.btnHGiris.TabIndex = 6;
            this.btnHGiris.Text = "Giriş Yap";
            this.btnHGiris.UseVisualStyleBackColor = false;
            this.btnHGiris.Click += new System.EventHandler(this.btnHGiris_Click);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btnHGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(314, 229);
            this.Controls.Add(this.btnHGiris);
            this.Controls.Add(this.lnkHGirisKayıt);
            this.Controls.Add(this.mtxtHGirisTc);
            this.Controls.Add(this.txtHGirisSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "FrmHastaGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHGirisSifre;
        private System.Windows.Forms.MaskedTextBox mtxtHGirisTc;
        private System.Windows.Forms.LinkLabel lnkHGirisKayıt;
        private System.Windows.Forms.Button btnHGiris;
    }
}