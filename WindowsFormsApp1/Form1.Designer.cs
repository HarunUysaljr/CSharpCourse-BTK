namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsayı1 = new System.Windows.Forms.TextBox();
            this.txtsayı2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCıkar = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2";
            // 
            // txtsayı1
            // 
            this.txtsayı1.Location = new System.Drawing.Point(224, 55);
            this.txtsayı1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtsayı1.Name = "txtsayı1";
            this.txtsayı1.Size = new System.Drawing.Size(100, 20);
            this.txtsayı1.TabIndex = 2;
            // 
            // txtsayı2
            // 
            this.txtsayı2.Location = new System.Drawing.Point(224, 101);
            this.txtsayı2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtsayı2.Name = "txtsayı2";
            this.txtsayı2.Size = new System.Drawing.Size(100, 20);
            this.txtsayı2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(464, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(62, 170);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 5;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCıkar
            // 
            this.btnCıkar.Location = new System.Drawing.Point(224, 170);
            this.btnCıkar.Name = "btnCıkar";
            this.btnCıkar.Size = new System.Drawing.Size(75, 23);
            this.btnCıkar.TabIndex = 7;
            this.btnCıkar.Text = "-";
            this.btnCıkar.UseVisualStyleBackColor = true;
            this.btnCıkar.Click += new System.EventHandler(this.btnCıkar_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(304, 170);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(75, 23);
            this.btnBol.TabIndex = 8;
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 336);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCıkar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsayı2);
            this.Controls.Add(this.txtsayı1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsayı1;
        private System.Windows.Forms.TextBox txtsayı2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCıkar;
        private System.Windows.Forms.Button btnBol;
    }
}

