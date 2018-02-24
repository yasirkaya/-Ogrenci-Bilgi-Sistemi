namespace obs_çalışma
{
    partial class yeni_kayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtDanisman = new System.Windows.Forms.TextBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.k_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "İsim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Soyisim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danışman Id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bölüm Id";
            // 
            // txtNumara
            // 
            this.txtNumara.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNumara.Location = new System.Drawing.Point(135, 9);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 1;
            this.txtNumara.Text = "9 karakter";
            this.txtNumara.Click += new System.EventHandler(this.txtNumara_Click);
            this.txtNumara.TextChanged += new System.EventHandler(this.txtNumara_TextChanged);
            // 
            // txtTc
            // 
            this.txtTc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTc.Location = new System.Drawing.Point(135, 45);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 2;
            this.txtTc.Text = "11 karakter";
            this.txtTc.Click += new System.EventHandler(this.txtTc_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(135, 81);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(135, 119);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtDanisman
            // 
            this.txtDanisman.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDanisman.Location = new System.Drawing.Point(135, 151);
            this.txtDanisman.Name = "txtDanisman";
            this.txtDanisman.Size = new System.Drawing.Size(100, 20);
            this.txtDanisman.TabIndex = 5;
            this.txtDanisman.Text = "5 karakter";
            this.txtDanisman.Click += new System.EventHandler(this.txtDanisman_Click);
            // 
            // txtBolum
            // 
            this.txtBolum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBolum.Location = new System.Drawing.Point(135, 186);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(100, 20);
            this.txtBolum.TabIndex = 6;
            this.txtBolum.Text = "3 karakter";
            this.txtBolum.Click += new System.EventHandler(this.txtBolum_Click);
            // 
            // k_ekle
            // 
            this.k_ekle.Location = new System.Drawing.Point(77, 227);
            this.k_ekle.Name = "k_ekle";
            this.k_ekle.Size = new System.Drawing.Size(95, 23);
            this.k_ekle.TabIndex = 7;
            this.k_ekle.Text = "Kayıt Ekle";
            this.k_ekle.UseVisualStyleBackColor = true;
            this.k_ekle.Click += new System.EventHandler(this.k_ekle_Click_1);
            // 
            // yeni_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 262);
            this.Controls.Add(this.k_ekle);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.txtDanisman);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yeni_kayit";
            this.Text = "Yeni Öğrenci Kaydı";
            this.Load += new System.EventHandler(this.yeni_kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtDanisman;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Button k_ekle;
    }
}