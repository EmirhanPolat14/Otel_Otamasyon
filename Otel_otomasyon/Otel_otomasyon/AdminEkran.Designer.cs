namespace Otel_otomasyon
{
    partial class AdminEkran
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
            this.btnoda1 = new System.Windows.Forms.Button();
            this.gbgelecek = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgeski = new System.Windows.Forms.DataGridView();
            this.lbloda1 = new System.Windows.Forms.Label();
            this.btnoda2 = new System.Windows.Forms.Button();
            this.lbloda2 = new System.Windows.Forms.Label();
            this.btnoda3 = new System.Windows.Forms.Button();
            this.lbloda3 = new System.Windows.Forms.Label();
            this.btnoda4 = new System.Windows.Forms.Button();
            this.lbloda4 = new System.Windows.Forms.Label();
            this.btnoda5 = new System.Windows.Forms.Button();
            this.lbloda5 = new System.Windows.Forms.Label();
            this.btnoda6 = new System.Windows.Forms.Button();
            this.lbloda6 = new System.Windows.Forms.Label();
            this.btnoda7 = new System.Windows.Forms.Button();
            this.lbloda7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.kisi = new System.Windows.Forms.MaskedTextBox();
            this.eyatak = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbgelecek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgeski)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnoda1
            // 
            this.btnoda1.BackColor = System.Drawing.Color.LightCyan;
            this.btnoda1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoda1.Location = new System.Drawing.Point(44, 109);
            this.btnoda1.Name = "btnoda1";
            this.btnoda1.Size = new System.Drawing.Size(242, 107);
            this.btnoda1.TabIndex = 0;
            this.btnoda1.Text = "ODA 1";
            this.btnoda1.UseVisualStyleBackColor = false;
            // 
            // gbgelecek
            // 
            this.gbgelecek.Controls.Add(this.comboBox1);
            this.gbgelecek.Controls.Add(this.dgeski);
            this.gbgelecek.Location = new System.Drawing.Point(20, 491);
            this.gbgelecek.Name = "gbgelecek";
            this.gbgelecek.Size = new System.Drawing.Size(730, 226);
            this.gbgelecek.TabIndex = 2;
            this.gbgelecek.TabStop = false;
            this.gbgelecek.Text = "Rezervasyon Takvimi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bu Ayın Rezervasyonları",
            "Oteldeki Müşteriler"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 36);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.AdminEkran_Load);
            // 
            // dgeski
            // 
            this.dgeski.AllowUserToAddRows = false;
            this.dgeski.AllowUserToDeleteRows = false;
            this.dgeski.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgeski.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgeski.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgeski.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgeski.Location = new System.Drawing.Point(3, 32);
            this.dgeski.Name = "dgeski";
            this.dgeski.ReadOnly = true;
            this.dgeski.RowHeadersWidth = 51;
            this.dgeski.RowTemplate.Height = 24;
            this.dgeski.Size = new System.Drawing.Size(724, 191);
            this.dgeski.TabIndex = 0;
            // 
            // lbloda1
            // 
            this.lbloda1.AutoSize = true;
            this.lbloda1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloda1.Location = new System.Drawing.Point(47, 219);
            this.lbloda1.Name = "lbloda1";
            this.lbloda1.Size = new System.Drawing.Size(242, 56);
            this.lbloda1.TabIndex = 3;
            this.lbloda1.Text = "Bir sonraki rezervasyona\r\n100 gün var.\r\n";
            // 
            // btnoda2
            // 
            this.btnoda2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoda2.Location = new System.Drawing.Point(292, 109);
            this.btnoda2.Name = "btnoda2";
            this.btnoda2.Size = new System.Drawing.Size(242, 107);
            this.btnoda2.TabIndex = 0;
            this.btnoda2.Text = "ODA 2";
            this.btnoda2.UseVisualStyleBackColor = true;
            // 
            // lbloda2
            // 
            this.lbloda2.AutoSize = true;
            this.lbloda2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloda2.Location = new System.Drawing.Point(292, 219);
            this.lbloda2.Name = "lbloda2";
            this.lbloda2.Size = new System.Drawing.Size(242, 56);
            this.lbloda2.TabIndex = 3;
            this.lbloda2.Text = "Bir sonraki rezervasyona\r\n100 gün var.\r\n";
            // 
            // btnoda3
            // 
            this.btnoda3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoda3.Location = new System.Drawing.Point(540, 109);
            this.btnoda3.Name = "btnoda3";
            this.btnoda3.Size = new System.Drawing.Size(242, 107);
            this.btnoda3.TabIndex = 0;
            this.btnoda3.Text = "ODA 3";
            this.btnoda3.UseVisualStyleBackColor = true;
            // 
            // lbloda3
            // 
            this.lbloda3.AutoSize = true;
            this.lbloda3.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloda3.Location = new System.Drawing.Point(540, 219);
            this.lbloda3.Name = "lbloda3";
            this.lbloda3.Size = new System.Drawing.Size(242, 56);
            this.lbloda3.TabIndex = 3;
            this.lbloda3.Text = "Bir sonraki rezervasyona\r\n100 gün var.\r\n";
            // 
            // btnoda4
            // 
            this.btnoda4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoda4.Location = new System.Drawing.Point(788, 109);
            this.btnoda4.Name = "btnoda4";
            this.btnoda4.Size = new System.Drawing.Size(242, 107);
            this.btnoda4.TabIndex = 0;
            this.btnoda4.Text = "ODA 4";
            this.btnoda4.UseVisualStyleBackColor = true;
            // 
            // lbloda4
            // 
            this.lbloda4.AutoSize = true;
            this.lbloda4.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloda4.Location = new System.Drawing.Point(788, 219);
            this.lbloda4.Name = "lbloda4";
            this.lbloda4.Size = new System.Drawing.Size(242, 56);
            this.lbloda4.TabIndex = 3;
            this.lbloda4.Text = "Bir sonraki rezervasyona\r\n100 gün var.\r\n";
            // 
            // btnoda5
            // 
            this.btnoda5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoda5.Location = new System.Drawing.Point(129, 301);
            this.btnoda5.Name = "btnoda5";
            this.btnoda5.Size = new System.Drawing.Size(242, 107);
            this.btnoda5.TabIndex = 0;
            this.btnoda5.Text = "ODA 5";
            this.btnoda5.UseVisualStyleBackColor = true;
            // 
            // lbloda5
            // 
            this.lbloda5.AutoSize = true;
            this.lbloda5.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloda5.Location = new System.Drawing.Point(132, 411);
            this.lbloda5.Name = "lbloda5";
            this.lbloda5.Size = new System.Drawing.Size(242, 56);
            this.lbloda5.TabIndex = 3;
            this.lbloda5.Text = "Bir sonraki rezervasyona\r\n100 gün var.\r\n";
            // 
            // btnoda6
            // 
            this.btnoda6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoda6.Location = new System.Drawing.Point(377, 301);
            this.btnoda6.Name = "btnoda6";
            this.btnoda6.Size = new System.Drawing.Size(242, 107);
            this.btnoda6.TabIndex = 0;
            this.btnoda6.Text = "ODA 6";
            this.btnoda6.UseVisualStyleBackColor = true;
            // 
            // lbloda6
            // 
            this.lbloda6.AutoSize = true;
            this.lbloda6.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloda6.Location = new System.Drawing.Point(380, 411);
            this.lbloda6.Name = "lbloda6";
            this.lbloda6.Size = new System.Drawing.Size(242, 56);
            this.lbloda6.TabIndex = 3;
            this.lbloda6.Text = "Bir sonraki rezervasyona\r\n100 gün var.\r\n";
            // 
            // btnoda7
            // 
            this.btnoda7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoda7.Location = new System.Drawing.Point(625, 301);
            this.btnoda7.Name = "btnoda7";
            this.btnoda7.Size = new System.Drawing.Size(242, 107);
            this.btnoda7.TabIndex = 0;
            this.btnoda7.Text = "ODA 7";
            this.btnoda7.UseVisualStyleBackColor = true;
            // 
            // lbloda7
            // 
            this.lbloda7.AutoSize = true;
            this.lbloda7.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloda7.Location = new System.Drawing.Point(628, 411);
            this.lbloda7.Name = "lbloda7";
            this.lbloda7.Size = new System.Drawing.Size(242, 56);
            this.lbloda7.TabIndex = 3;
            this.lbloda7.Text = "Bir sonraki rezervasyona\r\n100 gün var.\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(532, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 28);
            this.label12.TabIndex = 33;
            this.label12.Text = "Ek Yatak:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 28);
            this.label10.TabIndex = 34;
            this.label10.Text = "Konaklayacak Kişi Sayısı:";
            // 
            // kisi
            // 
            this.kisi.Location = new System.Drawing.Point(439, 43);
            this.kisi.Mask = "00";
            this.kisi.Name = "kisi";
            this.kisi.Size = new System.Drawing.Size(86, 36);
            this.kisi.TabIndex = 31;
            this.kisi.ValidatingType = typeof(int);
            // 
            // eyatak
            // 
            this.eyatak.Location = new System.Drawing.Point(634, 43);
            this.eyatak.Mask = "00";
            this.eyatak.Name = "eyatak";
            this.eyatak.Size = new System.Drawing.Size(87, 36);
            this.eyatak.TabIndex = 32;
            this.eyatak.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(727, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 35;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTemizle.Location = new System.Drawing.Point(848, 42);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(115, 36);
            this.btnTemizle.TabIndex = 35;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.checkoutToolStripMenuItem.Text = "Check-out";
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.checkoutToolStripMenuItem_Click);
            // 
            // AdminEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.kisi);
            this.Controls.Add(this.eyatak);
            this.Controls.Add(this.lbloda4);
            this.Controls.Add(this.lbloda3);
            this.Controls.Add(this.lbloda2);
            this.Controls.Add(this.lbloda7);
            this.Controls.Add(this.lbloda6);
            this.Controls.Add(this.lbloda5);
            this.Controls.Add(this.lbloda1);
            this.Controls.Add(this.gbgelecek);
            this.Controls.Add(this.btnoda4);
            this.Controls.Add(this.btnoda7);
            this.Controls.Add(this.btnoda3);
            this.Controls.Add(this.btnoda6);
            this.Controls.Add(this.btnoda2);
            this.Controls.Add(this.btnoda5);
            this.Controls.Add(this.btnoda1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminEkran";
            this.Text = "AdminEkran";
            this.Load += new System.EventHandler(this.AdminEkran_Load);
            this.gbgelecek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgeski)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnoda1;
        private System.Windows.Forms.GroupBox gbgelecek;
        private System.Windows.Forms.DataGridView dgeski;
        private System.Windows.Forms.Label lbloda1;
        private System.Windows.Forms.Button btnoda2;
        private System.Windows.Forms.Label lbloda2;
        private System.Windows.Forms.Button btnoda3;
        private System.Windows.Forms.Label lbloda3;
        private System.Windows.Forms.Button btnoda4;
        private System.Windows.Forms.Label lbloda4;
        private System.Windows.Forms.Button btnoda5;
        private System.Windows.Forms.Label lbloda5;
        private System.Windows.Forms.Button btnoda6;
        private System.Windows.Forms.Label lbloda6;
        private System.Windows.Forms.Button btnoda7;
        private System.Windows.Forms.Label lbloda7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox kisi;
        private System.Windows.Forms.MaskedTextBox eyatak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
    }
}