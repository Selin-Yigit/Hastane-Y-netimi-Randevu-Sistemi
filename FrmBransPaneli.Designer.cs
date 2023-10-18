namespace HastaneYönetimiRandevuSistemi
{
    partial class FrmBransPaneli
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
            this.txtBPaneliAd = new System.Windows.Forms.TextBox();
            this.txtBPaneliId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBPaneliEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBPaneliSil = new System.Windows.Forms.Button();
            this.btnBPaneliGuncelle = new System.Windows.Forms.Button();
            this.dgvBransPaneli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBransPaneli)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBPaneliAd
            // 
            this.txtBPaneliAd.Location = new System.Drawing.Point(109, 100);
            this.txtBPaneliAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBPaneliAd.Name = "txtBPaneliAd";
            this.txtBPaneliAd.Size = new System.Drawing.Size(208, 22);
            this.txtBPaneliAd.TabIndex = 12;
            // 
            // txtBPaneliId
            // 
            this.txtBPaneliId.Location = new System.Drawing.Point(109, 68);
            this.txtBPaneliId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBPaneliId.Name = "txtBPaneliId";
            this.txtBPaneliId.Size = new System.Drawing.Size(208, 22);
            this.txtBPaneliId.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Branş Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Branş Id: ";
            // 
            // btnBPaneliEkle
            // 
            this.btnBPaneliEkle.BackColor = System.Drawing.Color.Teal;
            this.btnBPaneliEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBPaneliEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBPaneliEkle.Location = new System.Drawing.Point(109, 148);
            this.btnBPaneliEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBPaneliEkle.Name = "btnBPaneliEkle";
            this.btnBPaneliEkle.Size = new System.Drawing.Size(96, 39);
            this.btnBPaneliEkle.TabIndex = 14;
            this.btnBPaneliEkle.Text = "Ekle";
            this.btnBPaneliEkle.UseVisualStyleBackColor = false;
            this.btnBPaneliEkle.Click += new System.EventHandler(this.btnBPaneliEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(360, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Branş Paneli";
            // 
            // btnBPaneliSil
            // 
            this.btnBPaneliSil.BackColor = System.Drawing.Color.Teal;
            this.btnBPaneliSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBPaneliSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBPaneliSil.Location = new System.Drawing.Point(222, 148);
            this.btnBPaneliSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBPaneliSil.Name = "btnBPaneliSil";
            this.btnBPaneliSil.Size = new System.Drawing.Size(96, 39);
            this.btnBPaneliSil.TabIndex = 16;
            this.btnBPaneliSil.Text = "Sil";
            this.btnBPaneliSil.UseVisualStyleBackColor = false;
            this.btnBPaneliSil.Click += new System.EventHandler(this.btnBPaneliSil_Click);
            // 
            // btnBPaneliGuncelle
            // 
            this.btnBPaneliGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnBPaneliGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBPaneliGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBPaneliGuncelle.Location = new System.Drawing.Point(109, 195);
            this.btnBPaneliGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBPaneliGuncelle.Name = "btnBPaneliGuncelle";
            this.btnBPaneliGuncelle.Size = new System.Drawing.Size(209, 39);
            this.btnBPaneliGuncelle.TabIndex = 17;
            this.btnBPaneliGuncelle.Text = "Güncelle";
            this.btnBPaneliGuncelle.UseVisualStyleBackColor = false;
            this.btnBPaneliGuncelle.Click += new System.EventHandler(this.btnBPaneliGuncelle_Click);
            // 
            // dgvBransPaneli
            // 
            this.dgvBransPaneli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBransPaneli.Location = new System.Drawing.Point(365, 68);
            this.dgvBransPaneli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBransPaneli.Name = "dgvBransPaneli";
            this.dgvBransPaneli.Size = new System.Drawing.Size(416, 166);
            this.dgvBransPaneli.TabIndex = 18;
            this.dgvBransPaneli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBransPaneli_CellClick);
            // 
            // FrmBransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(798, 255);
            this.Controls.Add(this.dgvBransPaneli);
            this.Controls.Add(this.btnBPaneliGuncelle);
            this.Controls.Add(this.btnBPaneliSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBPaneliEkle);
            this.Controls.Add(this.txtBPaneliAd);
            this.Controls.Add(this.txtBPaneliId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBransPaneli";
            this.Text = "FrmBransPaneli";
            this.Load += new System.EventHandler(this.FrmBransPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBransPaneli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBPaneliAd;
        private System.Windows.Forms.TextBox txtBPaneliId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBPaneliEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBPaneliSil;
        private System.Windows.Forms.Button btnBPaneliGuncelle;
        private System.Windows.Forms.DataGridView dgvBransPaneli;
    }
}