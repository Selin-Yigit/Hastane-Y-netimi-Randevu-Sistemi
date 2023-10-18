namespace HastaneYönetimiRandevuSistemi
{
    partial class FrmSekreterGiris
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
            this.btnSGiris = new System.Windows.Forms.Button();
            this.mtxtSGirisTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSGirisSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSGiris
            // 
            this.btnSGiris.BackColor = System.Drawing.Color.Teal;
            this.btnSGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSGiris.Location = new System.Drawing.Point(106, 142);
            this.btnSGiris.Name = "btnSGiris";
            this.btnSGiris.Size = new System.Drawing.Size(143, 35);
            this.btnSGiris.TabIndex = 12;
            this.btnSGiris.Text = "Giriş Yap";
            this.btnSGiris.UseVisualStyleBackColor = false;
            this.btnSGiris.Click += new System.EventHandler(this.btnSGiris_Click);
            // 
            // mtxtSGirisTc
            // 
            this.mtxtSGirisTc.Location = new System.Drawing.Point(106, 80);
            this.mtxtSGirisTc.Mask = "00000000000";
            this.mtxtSGirisTc.Name = "mtxtSGirisTc";
            this.mtxtSGirisTc.Size = new System.Drawing.Size(143, 20);
            this.mtxtSGirisTc.TabIndex = 1;
            this.mtxtSGirisTc.ValidatingType = typeof(int);
            // 
            // txtSGirisSifre
            // 
            this.txtSGirisSifre.Location = new System.Drawing.Point(106, 106);
            this.txtSGirisSifre.Name = "txtSGirisSifre";
            this.txtSGirisSifre.Size = new System.Drawing.Size(143, 20);
            this.txtSGirisSifre.TabIndex = 2;
            this.txtSGirisSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TC Kimlik No: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sekreter Giriş Paneli";
            // 
            // FrmSekreterGiris
            // 
            this.AcceptButton = this.btnSGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(312, 218);
            this.Controls.Add(this.btnSGiris);
            this.Controls.Add(this.mtxtSGirisTc);
            this.Controls.Add(this.txtSGirisSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSekreterGiris";
            this.Text = "FrmSekreterGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSGiris;
        private System.Windows.Forms.MaskedTextBox mtxtSGirisTc;
        private System.Windows.Forms.TextBox txtSGirisSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}