namespace HastaneYönetimiRandevuSistemi
{
    partial class FrmSekreterDetay
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
            this.lblSDetayAdSoyad = new System.Windows.Forms.Label();
            this.lblSDetayTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSDetayDuyuru = new System.Windows.Forms.Button();
            this.rtxtSDetayDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbSDetayBrans = new System.Windows.Forms.ComboBox();
            this.btnSDetayKaydet = new System.Windows.Forms.Button();
            this.txtSDetayId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtSDetaySaat = new System.Windows.Forms.MaskedTextBox();
            this.chckSDetayDurum = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtSDetayHastaTc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtSDetayTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbSDetayDoktor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSDetayBrans = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSDetayDoktor = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSDetayRandListesi = new System.Windows.Forms.Button();
            this.btnSDetayBransPaneli = new System.Windows.Forms.Button();
            this.btnSDetayDoktorPaneli = new System.Windows.Forms.Button();
            this.btnSDetayDuyurular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSDetayBrans)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSDetayDoktor)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSDetayAdSoyad);
            this.groupBox1.Controls.Add(this.lblSDetayTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(36, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(389, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgileri";
            // 
            // lblSDetayAdSoyad
            // 
            this.lblSDetayAdSoyad.AutoSize = true;
            this.lblSDetayAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSDetayAdSoyad.Location = new System.Drawing.Point(208, 98);
            this.lblSDetayAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDetayAdSoyad.Name = "lblSDetayAdSoyad";
            this.lblSDetayAdSoyad.Size = new System.Drawing.Size(52, 17);
            this.lblSDetayAdSoyad.TabIndex = 11;
            this.lblSDetayAdSoyad.Text = "           ";
            // 
            // lblSDetayTC
            // 
            this.lblSDetayTC.AutoSize = true;
            this.lblSDetayTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSDetayTC.Location = new System.Drawing.Point(208, 57);
            this.lblSDetayTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDetayTC.Name = "lblSDetayTC";
            this.lblSDetayTC.Size = new System.Drawing.Size(96, 17);
            this.lblSDetayTC.TabIndex = 10;
            this.lblSDetayTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad Soyad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "TC Kimlik No: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSDetayDuyuru);
            this.groupBox2.Controls.Add(this.rtxtSDetayDuyuru);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(36, 224);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(389, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnSDetayDuyuru
            // 
            this.btnSDetayDuyuru.BackColor = System.Drawing.Color.Teal;
            this.btnSDetayDuyuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSDetayDuyuru.Location = new System.Drawing.Point(31, 223);
            this.btnSDetayDuyuru.Margin = new System.Windows.Forms.Padding(4);
            this.btnSDetayDuyuru.Name = "btnSDetayDuyuru";
            this.btnSDetayDuyuru.Size = new System.Drawing.Size(331, 38);
            this.btnSDetayDuyuru.TabIndex = 13;
            this.btnSDetayDuyuru.Text = "Oluştur";
            this.btnSDetayDuyuru.UseVisualStyleBackColor = false;
            this.btnSDetayDuyuru.Click += new System.EventHandler(this.btnSDetayDuyuru_Click);
            // 
            // rtxtSDetayDuyuru
            // 
            this.rtxtSDetayDuyuru.Location = new System.Drawing.Point(31, 36);
            this.rtxtSDetayDuyuru.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtSDetayDuyuru.Name = "rtxtSDetayDuyuru";
            this.rtxtSDetayDuyuru.Size = new System.Drawing.Size(329, 179);
            this.rtxtSDetayDuyuru.TabIndex = 12;
            this.rtxtSDetayDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbSDetayBrans);
            this.groupBox3.Controls.Add(this.btnSDetayKaydet);
            this.groupBox3.Controls.Add(this.txtSDetayId);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.mtxtSDetaySaat);
            this.groupBox3.Controls.Add(this.chckSDetayDurum);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.mtxtSDetayHastaTc);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.mtxtSDetayTarih);
            this.groupBox3.Controls.Add(this.cmbSDetayDoktor);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(459, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(389, 478);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Detayları";
            // 
            // cmbSDetayBrans
            // 
            this.cmbSDetayBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSDetayBrans.FormattingEnabled = true;
            this.cmbSDetayBrans.Location = new System.Drawing.Point(123, 164);
            this.cmbSDetayBrans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSDetayBrans.Name = "cmbSDetayBrans";
            this.cmbSDetayBrans.Size = new System.Drawing.Size(189, 24);
            this.cmbSDetayBrans.TabIndex = 27;
            this.cmbSDetayBrans.SelectedIndexChanged += new System.EventHandler(this.cmbSDetayBrans_SelectedIndexChanged);
            // 
            // btnSDetayKaydet
            // 
            this.btnSDetayKaydet.BackColor = System.Drawing.Color.Teal;
            this.btnSDetayKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSDetayKaydet.Location = new System.Drawing.Point(48, 330);
            this.btnSDetayKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnSDetayKaydet.Name = "btnSDetayKaydet";
            this.btnSDetayKaydet.Size = new System.Drawing.Size(284, 47);
            this.btnSDetayKaydet.TabIndex = 14;
            this.btnSDetayKaydet.Text = "Kaydet";
            this.btnSDetayKaydet.UseVisualStyleBackColor = false;
            this.btnSDetayKaydet.Click += new System.EventHandler(this.btnSDetayKaydet_Click);
            // 
            // txtSDetayId
            // 
            this.txtSDetayId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSDetayId.Location = new System.Drawing.Point(123, 57);
            this.txtSDetayId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDetayId.Name = "txtSDetayId";
            this.txtSDetayId.Size = new System.Drawing.Size(189, 23);
            this.txtSDetayId.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(85, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Id:";
            // 
            // mtxtSDetaySaat
            // 
            this.mtxtSDetaySaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtSDetaySaat.Location = new System.Drawing.Point(123, 128);
            this.mtxtSDetaySaat.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtSDetaySaat.Mask = "00:00";
            this.mtxtSDetaySaat.Name = "mtxtSDetaySaat";
            this.mtxtSDetaySaat.Size = new System.Drawing.Size(189, 23);
            this.mtxtSDetaySaat.TabIndex = 23;
            this.mtxtSDetaySaat.ValidatingType = typeof(System.DateTime);
            // 
            // chckSDetayDurum
            // 
            this.chckSDetayDurum.AutoSize = true;
            this.chckSDetayDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckSDetayDurum.Location = new System.Drawing.Point(123, 273);
            this.chckSDetayDurum.Margin = new System.Windows.Forms.Padding(4);
            this.chckSDetayDurum.Name = "chckSDetayDurum";
            this.chckSDetayDurum.Size = new System.Drawing.Size(62, 17);
            this.chckSDetayDurum.TabIndex = 28;
            this.chckSDetayDurum.Text = "Durum";
            this.chckSDetayDurum.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hasta Tc: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tarih: ";
            // 
            // mtxtSDetayHastaTc
            // 
            this.mtxtSDetayHastaTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtSDetayHastaTc.Location = new System.Drawing.Point(123, 238);
            this.mtxtSDetayHastaTc.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtSDetayHastaTc.Mask = "00000000000";
            this.mtxtSDetayHastaTc.Name = "mtxtSDetayHastaTc";
            this.mtxtSDetayHastaTc.Size = new System.Drawing.Size(189, 23);
            this.mtxtSDetayHastaTc.TabIndex = 24;
            this.mtxtSDetayHastaTc.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(44, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Doktor: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(60, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Saat: ";
            // 
            // mtxtSDetayTarih
            // 
            this.mtxtSDetayTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtSDetayTarih.Location = new System.Drawing.Point(123, 92);
            this.mtxtSDetayTarih.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtSDetayTarih.Mask = "00/00/0000";
            this.mtxtSDetayTarih.Name = "mtxtSDetayTarih";
            this.mtxtSDetayTarih.Size = new System.Drawing.Size(189, 23);
            this.mtxtSDetayTarih.TabIndex = 25;
            this.mtxtSDetayTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbSDetayDoktor
            // 
            this.cmbSDetayDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSDetayDoktor.FormattingEnabled = true;
            this.cmbSDetayDoktor.Location = new System.Drawing.Point(123, 201);
            this.cmbSDetayDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSDetayDoktor.Name = "cmbSDetayDoktor";
            this.cmbSDetayDoktor.Size = new System.Drawing.Size(189, 24);
            this.cmbSDetayDoktor.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(52, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Branş: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSDetayBrans);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(881, 31);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(389, 293);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dgvSDetayBrans
            // 
            this.dgvSDetayBrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSDetayBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSDetayBrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSDetayBrans.Location = new System.Drawing.Point(4, 23);
            this.dgvSDetayBrans.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSDetayBrans.Name = "dgvSDetayBrans";
            this.dgvSDetayBrans.Size = new System.Drawing.Size(381, 266);
            this.dgvSDetayBrans.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSDetayDoktor);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(881, 347);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(389, 293);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dgvSDetayDoktor
            // 
            this.dgvSDetayDoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSDetayDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSDetayDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSDetayDoktor.Location = new System.Drawing.Point(4, 23);
            this.dgvSDetayDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSDetayDoktor.Name = "dgvSDetayDoktor";
            this.dgvSDetayDoktor.Size = new System.Drawing.Size(381, 266);
            this.dgvSDetayDoktor.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSDetayDuyurular);
            this.groupBox6.Controls.Add(this.btnSDetayRandListesi);
            this.groupBox6.Controls.Add(this.btnSDetayBransPaneli);
            this.groupBox6.Controls.Add(this.btnSDetayDoktorPaneli);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Location = new System.Drawing.Point(36, 533);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(812, 107);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnSDetayRandListesi
            // 
            this.btnSDetayRandListesi.BackColor = System.Drawing.Color.Teal;
            this.btnSDetayRandListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSDetayRandListesi.Location = new System.Drawing.Point(433, 44);
            this.btnSDetayRandListesi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSDetayRandListesi.Name = "btnSDetayRandListesi";
            this.btnSDetayRandListesi.Size = new System.Drawing.Size(145, 38);
            this.btnSDetayRandListesi.TabIndex = 32;
            this.btnSDetayRandListesi.Text = "Randevu Listesi";
            this.btnSDetayRandListesi.UseVisualStyleBackColor = false;
            this.btnSDetayRandListesi.Click += new System.EventHandler(this.btnSDetayRandListesi_Click);
            // 
            // btnSDetayBransPaneli
            // 
            this.btnSDetayBransPaneli.BackColor = System.Drawing.Color.Teal;
            this.btnSDetayBransPaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSDetayBransPaneli.Location = new System.Drawing.Point(221, 44);
            this.btnSDetayBransPaneli.Margin = new System.Windows.Forms.Padding(4);
            this.btnSDetayBransPaneli.Name = "btnSDetayBransPaneli";
            this.btnSDetayBransPaneli.Size = new System.Drawing.Size(145, 38);
            this.btnSDetayBransPaneli.TabIndex = 31;
            this.btnSDetayBransPaneli.Text = "Branş Paneli";
            this.btnSDetayBransPaneli.UseVisualStyleBackColor = false;
            this.btnSDetayBransPaneli.Click += new System.EventHandler(this.btnSDetayBransPaneli_Click);
            // 
            // btnSDetayDoktorPaneli
            // 
            this.btnSDetayDoktorPaneli.BackColor = System.Drawing.Color.Teal;
            this.btnSDetayDoktorPaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSDetayDoktorPaneli.Location = new System.Drawing.Point(18, 44);
            this.btnSDetayDoktorPaneli.Margin = new System.Windows.Forms.Padding(4);
            this.btnSDetayDoktorPaneli.Name = "btnSDetayDoktorPaneli";
            this.btnSDetayDoktorPaneli.Size = new System.Drawing.Size(145, 38);
            this.btnSDetayDoktorPaneli.TabIndex = 30;
            this.btnSDetayDoktorPaneli.Text = "Doktor Paneli";
            this.btnSDetayDoktorPaneli.UseVisualStyleBackColor = false;
            this.btnSDetayDoktorPaneli.Click += new System.EventHandler(this.btnSDetayDoktorPaneli_Click);
            // 
            // btnSDetayDuyurular
            // 
            this.btnSDetayDuyurular.BackColor = System.Drawing.Color.Teal;
            this.btnSDetayDuyurular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSDetayDuyurular.Location = new System.Drawing.Point(646, 44);
            this.btnSDetayDuyurular.Margin = new System.Windows.Forms.Padding(4);
            this.btnSDetayDuyurular.Name = "btnSDetayDuyurular";
            this.btnSDetayDuyurular.Size = new System.Drawing.Size(145, 38);
            this.btnSDetayDuyurular.TabIndex = 33;
            this.btnSDetayDuyurular.Text = "Duyurular";
            this.btnSDetayDuyurular.UseVisualStyleBackColor = false;
            this.btnSDetayDuyurular.Click += new System.EventHandler(this.btnSDetayDuyurular_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1305, 670);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSDetayBrans)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSDetayDoktor)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblSDetayAdSoyad;
        private System.Windows.Forms.Label lblSDetayTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtSDetayDuyuru;
        private System.Windows.Forms.Button btnSDetayDuyuru;
        private System.Windows.Forms.Button btnSDetayKaydet;
        private System.Windows.Forms.CheckBox chckSDetayDurum;
        private System.Windows.Forms.ComboBox cmbSDetayBrans;
        private System.Windows.Forms.ComboBox cmbSDetayDoktor;
        private System.Windows.Forms.MaskedTextBox mtxtSDetayTarih;
        private System.Windows.Forms.MaskedTextBox mtxtSDetayHastaTc;
        private System.Windows.Forms.MaskedTextBox mtxtSDetaySaat;
        private System.Windows.Forms.TextBox txtSDetayId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSDetayRandListesi;
        private System.Windows.Forms.Button btnSDetayBransPaneli;
        private System.Windows.Forms.Button btnSDetayDoktorPaneli;
        private System.Windows.Forms.DataGridView dgvSDetayBrans;
        private System.Windows.Forms.DataGridView dgvSDetayDoktor;
        private System.Windows.Forms.Button btnSDetayDuyurular;
    }
}