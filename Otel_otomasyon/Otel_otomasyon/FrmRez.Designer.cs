namespace Otel_otomasyon
{
    partial class FrmRez
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
            this.components = new System.ComponentModel.Container();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.baslangic = new System.Windows.Forms.DateTimePicker();
            this.kadın = new System.Windows.Forms.RadioButton();
            this.erkek = new System.Windows.Forms.RadioButton();
            this.tel = new System.Windows.Forms.MaskedTextBox();
            this.bitis = new System.Windows.Forms.DateTimePicker();
            this.doğum = new System.Windows.Forms.DateTimePicker();
            this.mail = new System.Windows.Forms.TextBox();
            this.oda = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gecelikUcretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mevcutKapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxKapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet1 = new Otel_otomasyon.OtelDataSet1();
            this.odalarTableAdapter = new Otel_otomasyon.OtelDataSet1TableAdapters.OdalarTableAdapter();
            this.eyatak = new System.Windows.Forms.MaskedTextBox();
            this.kisi = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(381, 465);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(320, 36);
            this.tc.TabIndex = 4;
            this.tc.ValidatingType = typeof(int);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(381, 507);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(320, 36);
            this.ad.TabIndex = 5;
            this.ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_KeyPress);
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(381, 549);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(320, 36);
            this.soyad.TabIndex = 6;
            this.soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyad_KeyPress);
            // 
            // baslangic
            // 
            this.baslangic.Location = new System.Drawing.Point(377, 66);
            this.baslangic.Name = "baslangic";
            this.baslangic.Size = new System.Drawing.Size(320, 36);
            this.baslangic.TabIndex = 12;
            // 
            // kadın
            // 
            this.kadın.AutoSize = true;
            this.kadın.Location = new System.Drawing.Point(381, 675);
            this.kadın.Name = "kadın";
            this.kadın.Size = new System.Drawing.Size(87, 32);
            this.kadın.TabIndex = 9;
            this.kadın.TabStop = true;
            this.kadın.Text = "Kadın";
            this.kadın.UseVisualStyleBackColor = true;
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.Location = new System.Drawing.Point(511, 675);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(87, 32);
            this.erkek.TabIndex = 10;
            this.erkek.TabStop = true;
            this.erkek.Text = "Erkek";
            this.erkek.UseVisualStyleBackColor = true;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(381, 713);
            this.tel.Mask = "(999) 000-0000";
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(320, 36);
            this.tel.TabIndex = 11;
            // 
            // bitis
            // 
            this.bitis.Location = new System.Drawing.Point(377, 108);
            this.bitis.Name = "bitis";
            this.bitis.Size = new System.Drawing.Size(320, 36);
            this.bitis.TabIndex = 13;
            // 
            // doğum
            // 
            this.doğum.Location = new System.Drawing.Point(381, 633);
            this.doğum.Name = "doğum";
            this.doğum.Size = new System.Drawing.Size(320, 36);
            this.doğum.TabIndex = 8;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(381, 591);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(320, 36);
            this.mail.TabIndex = 7;
            // 
            // oda
            // 
            this.oda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oda.FormattingEnabled = true;
            this.oda.Location = new System.Drawing.Point(381, 423);
            this.oda.Name = "oda";
            this.oda.Size = new System.Drawing.Size(320, 36);
            this.oda.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(381, 755);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 59);
            this.button1.TabIndex = 14;
            this.button1.Text = "Rezervasyon Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "e-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 677);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cinsiyet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 716);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Rezervasyon Başlangıç Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "Rezervasyon Bitiş Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "Konaklayacak Kişi Sayısı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 28);
            this.label11.TabIndex = 7;
            this.label11.Text = "Oda Seçimi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(508, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 28);
            this.label12.TabIndex = 7;
            this.label12.Text = "Ek Yatak:";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.Aquamarine;
            this.btnara.Location = new System.Drawing.Point(458, 150);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(136, 59);
            this.btnara.TabIndex = 14;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(255, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 202);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odalar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaNoDataGridViewTextBoxColumn,
            this.gecelikUcretDataGridViewTextBoxColumn,
            this.mevcutKapasiteDataGridViewTextBoxColumn,
            this.maxKapasiteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odalarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // odaNoDataGridViewTextBoxColumn
            // 
            this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "Oda_No";
            this.odaNoDataGridViewTextBoxColumn.HeaderText = "Oda No";
            this.odaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
            this.odaNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.odaNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // gecelikUcretDataGridViewTextBoxColumn
            // 
            this.gecelikUcretDataGridViewTextBoxColumn.DataPropertyName = "Gecelik_Ucret";
            this.gecelikUcretDataGridViewTextBoxColumn.HeaderText = "Gecelik Ücret";
            this.gecelikUcretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gecelikUcretDataGridViewTextBoxColumn.Name = "gecelikUcretDataGridViewTextBoxColumn";
            this.gecelikUcretDataGridViewTextBoxColumn.ReadOnly = true;
            this.gecelikUcretDataGridViewTextBoxColumn.Width = 125;
            // 
            // mevcutKapasiteDataGridViewTextBoxColumn
            // 
            this.mevcutKapasiteDataGridViewTextBoxColumn.DataPropertyName = "Mevcut_Kapasite";
            this.mevcutKapasiteDataGridViewTextBoxColumn.HeaderText = "Mevcut Kapasite";
            this.mevcutKapasiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mevcutKapasiteDataGridViewTextBoxColumn.Name = "mevcutKapasiteDataGridViewTextBoxColumn";
            this.mevcutKapasiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.mevcutKapasiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxKapasiteDataGridViewTextBoxColumn
            // 
            this.maxKapasiteDataGridViewTextBoxColumn.DataPropertyName = "Max_Kapasite";
            this.maxKapasiteDataGridViewTextBoxColumn.HeaderText = "Max Kapasite";
            this.maxKapasiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxKapasiteDataGridViewTextBoxColumn.Name = "maxKapasiteDataGridViewTextBoxColumn";
            this.maxKapasiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxKapasiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.otelDataSet1;
            // 
            // otelDataSet1
            // 
            this.otelDataSet1.DataSetName = "OtelDataSet1";
            this.otelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // eyatak
            // 
            this.eyatak.Location = new System.Drawing.Point(610, 24);
            this.eyatak.Mask = "00";
            this.eyatak.Name = "eyatak";
            this.eyatak.Size = new System.Drawing.Size(87, 36);
            this.eyatak.TabIndex = 4;
            this.eyatak.ValidatingType = typeof(int);
            this.eyatak.Validating += new System.ComponentModel.CancelEventHandler(this.eyatak_Validating);
            // 
            // kisi
            // 
            this.kisi.Location = new System.Drawing.Point(415, 24);
            this.kisi.Mask = "00";
            this.kisi.Name = "kisi";
            this.kisi.Size = new System.Drawing.Size(86, 36);
            this.kisi.TabIndex = 4;
            this.kisi.ValidatingType = typeof(int);
            this.kisi.Validating += new System.ComponentModel.CancelEventHandler(this.kisi_Validating);
            // 
            // FrmRez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(943, 724);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oda);
            this.Controls.Add(this.erkek);
            this.Controls.Add(this.kadın);
            this.Controls.Add(this.doğum);
            this.Controls.Add(this.bitis);
            this.Controls.Add(this.baslangic);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.kisi);
            this.Controls.Add(this.eyatak);
            this.Controls.Add(this.tc);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRez";
            this.Text = "FrmRez";
            this.Load += new System.EventHandler(this.FrmRez_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox tc;
        public System.Windows.Forms.TextBox ad;
        public System.Windows.Forms.TextBox soyad;
        public System.Windows.Forms.DateTimePicker baslangic;
        public System.Windows.Forms.RadioButton kadın;
        public System.Windows.Forms.RadioButton erkek;
        public System.Windows.Forms.MaskedTextBox tel;
        public System.Windows.Forms.DateTimePicker bitis;
        public System.Windows.Forms.DateTimePicker doğum;
        public System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.ComboBox oda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtelDataSet1 otelDataSet1;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private OtelDataSet1TableAdapters.OdalarTableAdapter odalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gecelikUcretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mevcutKapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxKapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox eyatak;
        private System.Windows.Forms.MaskedTextBox kisi;
    }
}