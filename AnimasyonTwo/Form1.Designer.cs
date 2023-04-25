namespace AnimasyonTwo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Baslat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDurum = new System.Windows.Forms.Label();
            this.pcbAt1 = new System.Windows.Forms.PictureBox();
            this.pcbAt2 = new System.Windows.Forms.PictureBox();
            this.pcbAt3 = new System.Windows.Forms.PictureBox();
            this.lblBitis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Baslat
            // 
            this.button_Baslat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Baslat.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_Baslat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Baslat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Baslat.Location = new System.Drawing.Point(608, 12);
            this.button_Baslat.Name = "button_Baslat";
            this.button_Baslat.Size = new System.Drawing.Size(87, 62);
            this.button_Baslat.TabIndex = 0;
            this.button_Baslat.Text = "Yarısı Baslat";
            this.button_Baslat.UseVisualStyleBackColor = true;
            this.button_Baslat.Click += new System.EventHandler(this.button_Baslat_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 62);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(12, 12);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(19, 25);
            this.lblDurum.TabIndex = 3;
            this.lblDurum.Text = "-";
            // 
            // pcbAt1
            // 
            this.pcbAt1.Image = ((System.Drawing.Image)(resources.GetObject("pcbAt1.Image")));
            this.pcbAt1.Location = new System.Drawing.Point(17, 61);
            this.pcbAt1.Name = "pcbAt1";
            this.pcbAt1.Size = new System.Drawing.Size(132, 101);
            this.pcbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt1.TabIndex = 4;
            this.pcbAt1.TabStop = false;
            // 
            // pcbAt2
            // 
            this.pcbAt2.Image = ((System.Drawing.Image)(resources.GetObject("pcbAt2.Image")));
            this.pcbAt2.Location = new System.Drawing.Point(17, 178);
            this.pcbAt2.Name = "pcbAt2";
            this.pcbAt2.Size = new System.Drawing.Size(132, 98);
            this.pcbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt2.TabIndex = 5;
            this.pcbAt2.TabStop = false;
            // 
            // pcbAt3
            // 
            this.pcbAt3.Image = ((System.Drawing.Image)(resources.GetObject("pcbAt3.Image")));
            this.pcbAt3.Location = new System.Drawing.Point(17, 291);
            this.pcbAt3.Name = "pcbAt3";
            this.pcbAt3.Size = new System.Drawing.Size(132, 92);
            this.pcbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt3.TabIndex = 6;
            this.pcbAt3.TabStop = false;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitis.Location = new System.Drawing.Point(12, 416);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(19, 25);
            this.lblBitis.TabIndex = 7;
            this.lblBitis.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.pcbAt3);
            this.Controls.Add(this.pcbAt2);
            this.Controls.Add(this.pcbAt1);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Baslat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Baslat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.PictureBox pcbAt1;
        private System.Windows.Forms.PictureBox pcbAt2;
        private System.Windows.Forms.PictureBox pcbAt3;
        private System.Windows.Forms.Label lblBitis;
    }
}

