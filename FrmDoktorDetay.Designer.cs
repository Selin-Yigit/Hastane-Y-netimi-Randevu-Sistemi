namespace HastaneYönetimiRandevuSistemi
{
    partial class FrmDoktorDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDDetayAdSoyad = new System.Windows.Forms.Label();
            this.lblDDetayTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtDDetaySikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDDetayCikis = new System.Windows.Forms.Button();
            this.btnDDetayDuyurular = new System.Windows.Forms.Button();
            this.btnDDetayUpdate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDDetayRndListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDDetayRndListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDDetayAdSoyad);
            this.groupBox1.Controls.Add(this.lblDDetayTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(35, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(413, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // lblDDetayAdSoyad
            // 
            this.lblDDetayAdSoyad.AutoSize = true;
            this.lblDDetayAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDDetayAdSoyad.Location = new System.Drawing.Point(212, 89);
            this.lblDDetayAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDDetayAdSoyad.Name = "lblDDetayAdSoyad";
            this.lblDDetayAdSoyad.Size = new System.Drawing.Size(52, 17);
            this.lblDDetayAdSoyad.TabIndex = 7;
            this.lblDDetayAdSoyad.Text = "           ";
            // 
            // lblDDetayTC
            // 
            this.lblDDetayTC.AutoSize = true;
            this.lblDDetayTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDDetayTC.Location = new System.Drawing.Point(212, 47);
            this.lblDDetayTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDDetayTC.Name = "lblDDetayTC";
            this.lblDDetayTC.Size = new System.Drawing.Size(96, 17);
            this.lblDDetayTC.TabIndex = 6;
            this.lblDDetayTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad Soyad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC Kimlik No: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtDDetaySikayet);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(35, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(413, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detayları";
            // 
            // rtxtDDetaySikayet
            // 
            this.rtxtDDetaySikayet.Location = new System.Drawing.Point(28, 36);
            this.rtxtDDetaySikayet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtDDetaySikayet.Name = "rtxtDDetaySikayet";
            this.rtxtDDetaySikayet.Size = new System.Drawing.Size(351, 157);
            this.rtxtDDetaySikayet.TabIndex = 0;
            this.rtxtDDetaySikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDDetayCikis);
            this.groupBox3.Controls.Add(this.btnDDetayDuyurular);
            this.groupBox3.Controls.Add(this.btnDDetayUpdate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(35, 437);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(413, 185);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı İşlemler";
            // 
            // btnDDetayCikis
            // 
            this.btnDDetayCikis.BackColor = System.Drawing.Color.Teal;
            this.btnDDetayCikis.Location = new System.Drawing.Point(29, 110);
            this.btnDDetayCikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDDetayCikis.Name = "btnDDetayCikis";
            this.btnDDetayCikis.Size = new System.Drawing.Size(351, 53);
            this.btnDDetayCikis.TabIndex = 2;
            this.btnDDetayCikis.Text = "Çıkış";
            this.btnDDetayCikis.UseVisualStyleBackColor = false;
            this.btnDDetayCikis.Click += new System.EventHandler(this.btnDDetayCikis_Click);
            // 
            // btnDDetayDuyurular
            // 
            this.btnDDetayDuyurular.BackColor = System.Drawing.Color.Teal;
            this.btnDDetayDuyurular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDDetayDuyurular.Location = new System.Drawing.Point(220, 37);
            this.btnDDetayDuyurular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDDetayDuyurular.Name = "btnDDetayDuyurular";
            this.btnDDetayDuyurular.Size = new System.Drawing.Size(160, 53);
            this.btnDDetayDuyurular.TabIndex = 1;
            this.btnDDetayDuyurular.Text = "Duyurular";
            this.btnDDetayDuyurular.UseVisualStyleBackColor = false;
            this.btnDDetayDuyurular.Click += new System.EventHandler(this.btnDDetayDuyurular_Click);
            // 
            // btnDDetayUpdate
            // 
            this.btnDDetayUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnDDetayUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDDetayUpdate.Location = new System.Drawing.Point(29, 37);
            this.btnDDetayUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDDetayUpdate.Name = "btnDDetayUpdate";
            this.btnDDetayUpdate.Size = new System.Drawing.Size(160, 53);
            this.btnDDetayUpdate.TabIndex = 0;
            this.btnDDetayUpdate.Text = "Bilgileri Güncelle";
            this.btnDDetayUpdate.UseVisualStyleBackColor = false;
            this.btnDDetayUpdate.Click += new System.EventHandler(this.btnDDetayUpdate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDDetayRndListesi);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(483, 31);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(661, 591);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Listesi";
            // 
            // dgvDDetayRndListesi
            // 
            this.dgvDDetayRndListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDDetayRndListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDDetayRndListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDDetayRndListesi.Location = new System.Drawing.Point(4, 23);
            this.dgvDDetayRndListesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDDetayRndListesi.Name = "dgvDDetayRndListesi";
            this.dgvDDetayRndListesi.Size = new System.Drawing.Size(653, 564);
            this.dgvDDetayRndListesi.TabIndex = 0;
            this.dgvDDetayRndListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDDetayRndListesi_CellClick);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1179, 654);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDoktorDetay";
            this.Text = "FrmDoktorDetay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDDetayRndListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDDetayAdSoyad;
        private System.Windows.Forms.Label lblDDetayTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtDDetaySikayet;
        private System.Windows.Forms.Button btnDDetayCikis;
        private System.Windows.Forms.Button btnDDetayDuyurular;
        private System.Windows.Forms.Button btnDDetayUpdate;
        private System.Windows.Forms.DataGridView dgvDDetayRndListesi;
    }
}