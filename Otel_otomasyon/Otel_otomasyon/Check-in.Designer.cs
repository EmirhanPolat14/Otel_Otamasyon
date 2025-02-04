namespace Otel_otomasyon
{
    partial class Check_in
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.erkek = new System.Windows.Forms.RadioButton();
            this.kadın = new System.Windows.Forms.RadioButton();
            this.doğum = new System.Windows.Forms.DateTimePicker();
            this.mail = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.MaskedTextBox();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rezno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "e-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "TC:";
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.Location = new System.Drawing.Point(414, 302);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(87, 32);
            this.erkek.TabIndex = 9;
            this.erkek.TabStop = true;
            this.erkek.Text = "Erkek";
            this.erkek.UseVisualStyleBackColor = true;
            // 
            // kadın
            // 
            this.kadın.AutoSize = true;
            this.kadın.Location = new System.Drawing.Point(284, 302);
            this.kadın.Name = "kadın";
            this.kadın.Size = new System.Drawing.Size(87, 32);
            this.kadın.TabIndex = 8;
            this.kadın.TabStop = true;
            this.kadın.Text = "Kadın";
            this.kadın.UseVisualStyleBackColor = true;
            // 
            // doğum
            // 
            this.doğum.Location = new System.Drawing.Point(284, 260);
            this.doğum.Name = "doğum";
            this.doğum.Size = new System.Drawing.Size(320, 36);
            this.doğum.TabIndex = 6;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(284, 218);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(320, 36);
            this.mail.TabIndex = 5;
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(284, 176);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(320, 36);
            this.soyad.TabIndex = 4;
            this.soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyad_KeyPress_1);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(284, 134);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(320, 36);
            this.ad.TabIndex = 3;
            this.ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_KeyPress_1);
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(284, 340);
            this.tel.Mask = "(999) 000-0000";
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(320, 36);
            this.tel.TabIndex = 7;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(284, 92);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(320, 36);
            this.tc.TabIndex = 2;
            this.tc.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "Rezervasyon Numarası:";
            // 
            // rezno
            // 
            this.rezno.Location = new System.Drawing.Point(284, 50);
            this.rezno.Name = "rezno";
            this.rezno.Size = new System.Drawing.Size(210, 36);
            this.rezno.TabIndex = 1;
            this.rezno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rezno_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(284, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Check_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(760, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rezno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.erkek);
            this.Controls.Add(this.kadın);
            this.Controls.Add(this.doğum);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.tc);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Check_in";
            this.Text = "Check_in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton erkek;
        public System.Windows.Forms.RadioButton kadın;
        public System.Windows.Forms.DateTimePicker doğum;
        public System.Windows.Forms.TextBox mail;
        public System.Windows.Forms.TextBox soyad;
        public System.Windows.Forms.TextBox ad;
        public System.Windows.Forms.MaskedTextBox tel;
        public System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox rezno;
        private System.Windows.Forms.Button button1;
    }
}