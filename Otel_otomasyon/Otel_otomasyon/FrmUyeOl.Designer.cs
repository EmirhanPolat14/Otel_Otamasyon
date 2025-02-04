namespace Otel_otomasyon
{
    partial class FrmUyeOl
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
            this.btnok = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.goster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "e-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "TC:";
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.Location = new System.Drawing.Point(365, 284);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(87, 32);
            this.erkek.TabIndex = 25;
            this.erkek.TabStop = true;
            this.erkek.Text = "Erkek";
            this.erkek.UseVisualStyleBackColor = true;
            // 
            // kadın
            // 
            this.kadın.AutoSize = true;
            this.kadın.Location = new System.Drawing.Point(235, 284);
            this.kadın.Name = "kadın";
            this.kadın.Size = new System.Drawing.Size(87, 32);
            this.kadın.TabIndex = 24;
            this.kadın.TabStop = true;
            this.kadın.Text = "Kadın";
            this.kadın.UseVisualStyleBackColor = true;
            // 
            // doğum
            // 
            this.doğum.Location = new System.Drawing.Point(235, 242);
            this.doğum.Name = "doğum";
            this.doğum.Size = new System.Drawing.Size(320, 36);
            this.doğum.TabIndex = 6;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(235, 200);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(320, 36);
            this.mail.TabIndex = 5;
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(235, 116);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(320, 36);
            this.soyad.TabIndex = 3;
            this.soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyad_KeyPress);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(235, 74);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(320, 36);
            this.ad.TabIndex = 2;
            this.ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_KeyPress);
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(235, 322);
            this.tel.Mask = "(999) 000-0000";
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(320, 36);
            this.tel.TabIndex = 7;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(235, 32);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(320, 36);
            this.tc.TabIndex = 1;
            this.tc.ValidatingType = typeof(int);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.Aquamarine;
            this.btnok.Location = new System.Drawing.Point(316, 364);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(136, 59);
            this.btnok.TabIndex = 27;
            this.btnok.Text = "Üye ol";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(235, 158);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(320, 36);
            this.sifre.TabIndex = 4;
            this.sifre.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Şifre:";
            // 
            // goster
            // 
            this.goster.AutoSize = true;
            this.goster.Location = new System.Drawing.Point(561, 160);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(97, 32);
            this.goster.TabIndex = 28;
            this.goster.Text = "Göster";
            this.goster.UseVisualStyleBackColor = true;
            this.goster.CheckedChanged += new System.EventHandler(this.goster_CheckedChanged);
            // 
            // FrmUyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(707, 482);
            this.Controls.Add(this.goster);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.erkek);
            this.Controls.Add(this.kadın);
            this.Controls.Add(this.doğum);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.tc);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUyeOl";
            this.Text = "FrmUyeOl";
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
        private System.Windows.Forms.RadioButton erkek;
        private System.Windows.Forms.RadioButton kadın;
        private System.Windows.Forms.DateTimePicker doğum;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.MaskedTextBox tel;
        private System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox goster;
    }
}