namespace IfOrnek6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.pcbAt1 = new System.Windows.Forms.PictureBox();
            this.pcbAt2 = new System.Windows.Forms.PictureBox();
            this.pcbAt3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 10);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 10);
            this.label2.TabIndex = 1;
            // 
            // lblBitis
            // 
            this.lblBitis.BackColor = System.Drawing.Color.White;
            this.lblBitis.Location = new System.Drawing.Point(666, 104);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(10, 386);
            this.lblBitis.TabIndex = 2;
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBaslat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaslat.Location = new System.Drawing.Point(560, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(116, 78);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "YARIŞI BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSifirla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSifirla.Location = new System.Drawing.Point(682, 12);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(116, 78);
            this.btnSifirla.TabIndex = 4;
            this.btnSifirla.Text = "YARIŞI SIFIRLA";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDurum.Location = new System.Drawing.Point(35, 39);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(20, 25);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "-";
            // 
            // pcbAt1
            // 
            this.pcbAt1.Image = ((System.Drawing.Image)(resources.GetObject("pcbAt1.Image")));
            this.pcbAt1.Location = new System.Drawing.Point(38, 104);
            this.pcbAt1.Name = "pcbAt1";
            this.pcbAt1.Size = new System.Drawing.Size(151, 106);
            this.pcbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt1.TabIndex = 6;
            this.pcbAt1.TabStop = false;
            // 
            // pcbAt2
            // 
            this.pcbAt2.Image = ((System.Drawing.Image)(resources.GetObject("pcbAt2.Image")));
            this.pcbAt2.Location = new System.Drawing.Point(37, 240);
            this.pcbAt2.Name = "pcbAt2";
            this.pcbAt2.Size = new System.Drawing.Size(152, 97);
            this.pcbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt2.TabIndex = 7;
            this.pcbAt2.TabStop = false;
            // 
            // pcbAt3
            // 
            this.pcbAt3.Image = ((System.Drawing.Image)(resources.GetObject("pcbAt3.Image")));
            this.pcbAt3.Location = new System.Drawing.Point(36, 390);
            this.pcbAt3.Name = "pcbAt3";
            this.pcbAt3.Size = new System.Drawing.Size(153, 97);
            this.pcbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAt3.TabIndex = 8;
            this.pcbAt3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(831, 499);
            this.Controls.Add(this.pcbAt3);
            this.Controls.Add(this.pcbAt2);
            this.Controls.Add(this.pcbAt1);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAt3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblBitis;
        private Button btnBaslat;
        private Button btnSifirla;
        private Label lblDurum;
        private PictureBox pcbAt1;
        private PictureBox pcbAt2;
        private PictureBox pcbAt3;
        private System.Windows.Forms.Timer timer1;
    }
}