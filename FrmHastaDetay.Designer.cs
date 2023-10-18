namespace HastaneYönetimiRandevuSistemi
{
    partial class FrmHastaDetay
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
            this.lnkHDetayUpdate = new System.Windows.Forms.LinkLabel();
            this.lblHDetayAdSoyad = new System.Windows.Forms.Label();
            this.lblHDetayTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHDetayRandId = new System.Windows.Forms.TextBox();
            this.btnHDetayRandevu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtHDetaySikayet = new System.Windows.Forms.RichTextBox();
            this.cmbHDetayDoktor = new System.Windows.Forms.ComboBox();
            this.cmbHDetayBrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHDetayRandGecmisi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvHDetayAktifRnd = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDetayRandGecmisi)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDetayAktifRnd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkHDetayUpdate);
            this.groupBox1.Controls.Add(this.lblHDetayAdSoyad);
            this.groupBox1.Controls.Add(this.lblHDetayTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(36, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(383, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // lnkHDetayUpdate
            // 
            this.lnkHDetayUpdate.AutoSize = true;
            this.lnkHDetayUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkHDetayUpdate.Location = new System.Drawing.Point(116, 143);
            this.lnkHDetayUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkHDetayUpdate.Name = "lnkHDetayUpdate";
            this.lnkHDetayUpdate.Size = new System.Drawing.Size(113, 17);
            this.lnkHDetayUpdate.TabIndex = 4;
            this.lnkHDetayUpdate.TabStop = true;
            this.lnkHDetayUpdate.Text = "Bilgileri Güncelle";
            this.lnkHDetayUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHDetayUpdate_LinkClicked);
            // 
            // lblHDetayAdSoyad
            // 
            this.lblHDetayAdSoyad.AutoSize = true;
            this.lblHDetayAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHDetayAdSoyad.Location = new System.Drawing.Point(183, 98);
            this.lblHDetayAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHDetayAdSoyad.Name = "lblHDetayAdSoyad";
            this.lblHDetayAdSoyad.Size = new System.Drawing.Size(52, 17);
            this.lblHDetayAdSoyad.TabIndex = 3;
            this.lblHDetayAdSoyad.Text = "           ";
            // 
            // lblHDetayTC
            // 
            this.lblHDetayTC.AutoSize = true;
            this.lblHDetayTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHDetayTC.Location = new System.Drawing.Point(183, 57);
            this.lblHDetayTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHDetayTC.Name = "lblHDetayTC";
            this.lblHDetayTC.Size = new System.Drawing.Size(96, 17);
            this.lblHDetayTC.TabIndex = 2;
            this.lblHDetayTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHDetayRandId);
            this.groupBox2.Controls.Add(this.btnHDetayRandevu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rtxtHDetaySikayet);
            this.groupBox2.Controls.Add(this.cmbHDetayDoktor);
            this.groupBox2.Controls.Add(this.cmbHDetayBrans);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(36, 235);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(383, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rnadevu Id: ";
            // 
            // txtHDetayRandId
            // 
            this.txtHDetayRandId.Enabled = false;
            this.txtHDetayRandId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHDetayRandId.Location = new System.Drawing.Point(172, 55);
            this.txtHDetayRandId.Margin = new System.Windows.Forms.Padding(4);
            this.txtHDetayRandId.Name = "txtHDetayRandId";
            this.txtHDetayRandId.Size = new System.Drawing.Size(160, 20);
            this.txtHDetayRandId.TabIndex = 7;
            // 
            // btnHDetayRandevu
            // 
            this.btnHDetayRandevu.BackColor = System.Drawing.Color.Teal;
            this.btnHDetayRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHDetayRandevu.Location = new System.Drawing.Point(172, 278);
            this.btnHDetayRandevu.Margin = new System.Windows.Forms.Padding(4);
            this.btnHDetayRandevu.Name = "btnHDetayRandevu";
            this.btnHDetayRandevu.Size = new System.Drawing.Size(161, 43);
            this.btnHDetayRandevu.TabIndex = 6;
            this.btnHDetayRandevu.Text = "Randevu Al";
            this.btnHDetayRandevu.UseVisualStyleBackColor = false;
            this.btnHDetayRandevu.Click += new System.EventHandler(this.btnHDetayRandevu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(69, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Şikayet: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(76, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Doktor: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(84, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Branş: ";
            // 
            // rtxtHDetaySikayet
            // 
            this.rtxtHDetaySikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtHDetaySikayet.Location = new System.Drawing.Point(172, 154);
            this.rtxtHDetaySikayet.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtHDetaySikayet.Name = "rtxtHDetaySikayet";
            this.rtxtHDetaySikayet.Size = new System.Drawing.Size(160, 117);
            this.rtxtHDetaySikayet.TabIndex = 2;
            this.rtxtHDetaySikayet.Text = "";
            // 
            // cmbHDetayDoktor
            // 
            this.cmbHDetayDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHDetayDoktor.FormattingEnabled = true;
            this.cmbHDetayDoktor.Location = new System.Drawing.Point(172, 121);
            this.cmbHDetayDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHDetayDoktor.Name = "cmbHDetayDoktor";
            this.cmbHDetayDoktor.Size = new System.Drawing.Size(160, 21);
            this.cmbHDetayDoktor.TabIndex = 1;
            this.cmbHDetayDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbHDetayDoktor_SelectedIndexChanged);
            // 
            // cmbHDetayBrans
            // 
            this.cmbHDetayBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHDetayBrans.FormattingEnabled = true;
            this.cmbHDetayBrans.Location = new System.Drawing.Point(172, 87);
            this.cmbHDetayBrans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHDetayBrans.Name = "cmbHDetayBrans";
            this.cmbHDetayBrans.Size = new System.Drawing.Size(160, 21);
            this.cmbHDetayBrans.TabIndex = 0;
            this.cmbHDetayBrans.SelectedIndexChanged += new System.EventHandler(this.cmbHDetayBrans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHDetayRandGecmisi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(459, 32);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(727, 267);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dgvHDetayRandGecmisi
            // 
            this.dgvHDetayRandGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDetayRandGecmisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDetayRandGecmisi.Location = new System.Drawing.Point(4, 23);
            this.dgvHDetayRandGecmisi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHDetayRandGecmisi.Name = "dgvHDetayRandGecmisi";
            this.dgvHDetayRandGecmisi.Size = new System.Drawing.Size(719, 240);
            this.dgvHDetayRandGecmisi.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvHDetayAktifRnd);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(459, 324);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(727, 267);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dgvHDetayAktifRnd
            // 
            this.dgvHDetayAktifRnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDetayAktifRnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDetayAktifRnd.Location = new System.Drawing.Point(4, 23);
            this.dgvHDetayAktifRnd.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHDetayAktifRnd.Name = "dgvHDetayAktifRnd";
            this.dgvHDetayAktifRnd.Size = new System.Drawing.Size(719, 240);
            this.dgvHDetayAktifRnd.TabIndex = 0;
            this.dgvHDetayAktifRnd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDetayAktifRnd_CellClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1217, 624);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHastaDetay";
            this.Text = "FrmHastaDetay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDetayRandGecmisi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDetayAktifRnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblHDetayAdSoyad;
        private System.Windows.Forms.Label lblHDetayTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkHDetayUpdate;
        private System.Windows.Forms.Button btnHDetayRandevu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtHDetaySikayet;
        private System.Windows.Forms.ComboBox cmbHDetayDoktor;
        private System.Windows.Forms.ComboBox cmbHDetayBrans;
        private System.Windows.Forms.DataGridView dgvHDetayRandGecmisi;
        private System.Windows.Forms.DataGridView dgvHDetayAktifRnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHDetayRandId;
    }
}