namespace obs_çalışma
{
    partial class ogretmen_menu
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
            this.ad = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.bolum = new System.Windows.Forms.Label();
            this.ders_ac = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.btn_dersSil = new System.Windows.Forms.Button();
            this.txt_silDers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(33, 39);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(35, 13);
            this.ad.TabIndex = 0;
            this.ad.Text = "label1";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Location = new System.Drawing.Point(33, 85);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(35, 13);
            this.soyad.TabIndex = 0;
            this.soyad.Text = "label1";
            // 
            // bolum
            // 
            this.bolum.AutoSize = true;
            this.bolum.Location = new System.Drawing.Point(33, 131);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(35, 13);
            this.bolum.TabIndex = 0;
            this.bolum.Text = "label1";
            // 
            // ders_ac
            // 
            this.ders_ac.Location = new System.Drawing.Point(158, 39);
            this.ders_ac.Name = "ders_ac";
            this.ders_ac.Size = new System.Drawing.Size(96, 23);
            this.ders_ac.TabIndex = 1;
            this.ders_ac.Text = "Ders Aç";
            this.ders_ac.UseVisualStyleBackColor = true;
            this.ders_ac.Click += new System.EventHandler(this.ders_ac_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Not Gir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(158, 143);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(96, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Ana Menü";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btn_dersSil
            // 
            this.btn_dersSil.Location = new System.Drawing.Point(12, 227);
            this.btn_dersSil.Name = "btn_dersSil";
            this.btn_dersSil.Size = new System.Drawing.Size(96, 23);
            this.btn_dersSil.TabIndex = 3;
            this.btn_dersSil.Text = "Ders Sil";
            this.btn_dersSil.UseVisualStyleBackColor = true;
            this.btn_dersSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_silDers
            // 
            this.txt_silDers.Location = new System.Drawing.Point(12, 201);
            this.txt_silDers.Name = "txt_silDers";
            this.txt_silDers.Size = new System.Drawing.Size(100, 20);
            this.txt_silDers.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek ders kodu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ogretmen_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 262);
            this.Controls.Add(this.txt_silDers);
            this.Controls.Add(this.btn_dersSil);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ders_ac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bolum);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Name = "ogretmen_menu";
            this.Text = "Öğretmen Giriş";
            this.Load += new System.EventHandler(this.ogretmen_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label bolum;
        private System.Windows.Forms.Button ders_ac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btn_dersSil;
        private System.Windows.Forms.TextBox txt_silDers;
        private System.Windows.Forms.Label label1;
    }
}