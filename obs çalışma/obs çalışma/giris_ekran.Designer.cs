namespace obs_çalışma
{
    partial class giris_ekran
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
            this.btn_ogrenci = new System.Windows.Forms.Button();
            this.btn_ogretmen = new System.Windows.Forms.Button();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(149, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "kullanıcı adı";
            // 
            // btn_ogrenci
            // 
            this.btn_ogrenci.Location = new System.Drawing.Point(31, 103);
            this.btn_ogrenci.Name = "btn_ogrenci";
            this.btn_ogrenci.Size = new System.Drawing.Size(93, 43);
            this.btn_ogrenci.TabIndex = 1;
            this.btn_ogrenci.Text = "Ogrenci Giris";
            this.btn_ogrenci.UseVisualStyleBackColor = true;
            this.btn_ogrenci.Click += new System.EventHandler(this.btn_ogrenci_Click);
            // 
            // btn_ogretmen
            // 
            this.btn_ogretmen.Location = new System.Drawing.Point(153, 103);
            this.btn_ogretmen.Name = "btn_ogretmen";
            this.btn_ogretmen.Size = new System.Drawing.Size(97, 43);
            this.btn_ogretmen.TabIndex = 1;
            this.btn_ogretmen.Text = "Ogretmen Giris";
            this.btn_ogretmen.UseVisualStyleBackColor = true;
            this.btn_ogretmen.Click += new System.EventHandler(this.btn_ogretmen_Click);
            // 
            // btn_yeni
            // 
            this.btn_yeni.Location = new System.Drawing.Point(31, 166);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(93, 40);
            this.btn_yeni.TabIndex = 1;
            this.btn_yeni.Text = "Yeni Kayit";
            this.btn_yeni.UseVisualStyleBackColor = true;
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(31, 77);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 2;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(153, 77);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 2;
            // 
            // giris_ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.btn_ogretmen);
            this.Controls.Add(this.btn_yeni);
            this.Controls.Add(this.btn_ogrenci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "giris_ekran";
            this.Text = "OBS Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.giris_ekran_FormClosing);
            this.Load += new System.EventHandler(this.giris_ekran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ogrenci;
        private System.Windows.Forms.Button btn_ogretmen;
        private System.Windows.Forms.Button btn_yeni;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtuser;
    }
}