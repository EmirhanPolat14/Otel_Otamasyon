namespace Otel_otomasyon
{
    partial class UyeEkrani
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
            this.dgeski = new System.Windows.Forms.DataGridView();
            this.gbgecmis = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbrezyap = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgeski)).BeginInit();
            this.gbgecmis.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgeski
            // 
            this.dgeski.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgeski.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgeski.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgeski.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgeski.Location = new System.Drawing.Point(3, 32);
            this.dgeski.Name = "dgeski";
            this.dgeski.RowHeadersWidth = 51;
            this.dgeski.RowTemplate.Height = 24;
            this.dgeski.Size = new System.Drawing.Size(862, 222);
            this.dgeski.TabIndex = 0;
            // 
            // gbgecmis
            // 
            this.gbgecmis.Controls.Add(this.dgeski);
            this.gbgecmis.Location = new System.Drawing.Point(30, 65);
            this.gbgecmis.Name = "gbgecmis";
            this.gbgecmis.Size = new System.Drawing.Size(868, 257);
            this.gbgecmis.TabIndex = 1;
            this.gbgecmis.TabStop = false;
            this.gbgecmis.Text = "Geçmiş Rezervasyonlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // gbrezyap
            // 
            this.gbrezyap.BackColor = System.Drawing.Color.Silver;
            this.gbrezyap.Location = new System.Drawing.Point(30, 328);
            this.gbrezyap.Name = "gbrezyap";
            this.gbrezyap.Size = new System.Drawing.Size(865, 358);
            this.gbrezyap.TabIndex = 3;
            this.gbrezyap.TabStop = false;
            this.gbrezyap.Text = "Rezervasyon Yaptır";
            // 
            // UyeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(920, 716);
            this.Controls.Add(this.gbrezyap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbgecmis);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UyeEkrani";
            this.Text = "UyeEkrani";
            this.Load += new System.EventHandler(this.UyeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgeski)).EndInit();
            this.gbgecmis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgeski;
        private System.Windows.Forms.GroupBox gbgecmis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbrezyap;
    }
}