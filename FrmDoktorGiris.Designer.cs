namespace HastaneYönetimiRandevuSistemi
{
    partial class FrmDoktorGiris
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
            this.btnDGiris = new System.Windows.Forms.Button();
            this.mtxtDGirisTc = new System.Windows.Forms.MaskedTextBox();
            this.txtDGirisSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDGiris
            // 
            this.btnDGiris.BackColor = System.Drawing.Color.Teal;
            this.btnDGiris.Location = new System.Drawing.Point(152, 175);
            this.btnDGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnDGiris.Name = "btnDGiris";
            this.btnDGiris.Size = new System.Drawing.Size(191, 43);
            this.btnDGiris.TabIndex = 12;
            this.btnDGiris.Text = "Giriş Yap";
            this.btnDGiris.UseVisualStyleBackColor = false;
            this.btnDGiris.Click += new System.EventHandler(this.btnDGiris_Click);
            // 
            // mtxtDGirisTc
            // 
            this.mtxtDGirisTc.Location = new System.Drawing.Point(152, 98);
            this.mtxtDGirisTc.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtDGirisTc.Mask = "00000000000";
            this.mtxtDGirisTc.Name = "mtxtDGirisTc";
            this.mtxtDGirisTc.Size = new System.Drawing.Size(189, 22);
            this.mtxtDGirisTc.TabIndex = 1;
            this.mtxtDGirisTc.ValidatingType = typeof(int);
            // 
            // txtDGirisSifre
            // 
            this.txtDGirisSifre.Location = new System.Drawing.Point(152, 130);
            this.txtDGirisSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtDGirisSifre.Name = "txtDGirisSifre";
            this.txtDGirisSifre.Size = new System.Drawing.Size(189, 22);
            this.txtDGirisSifre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "TC Kimlik No: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(83, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // FrmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(420, 288);
            this.Controls.Add(this.btnDGiris);
            this.Controls.Add(this.mtxtDGirisTc);
            this.Controls.Add(this.txtDGirisSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoktorGiris";
            this.Text = "FrmDoktorGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDGiris;
        private System.Windows.Forms.MaskedTextBox mtxtDGirisTc;
        private System.Windows.Forms.TextBox txtDGirisSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}