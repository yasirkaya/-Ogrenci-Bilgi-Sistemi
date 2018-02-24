namespace obs_çalışma
{
    partial class ders_ac
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
            this.dersKod = new System.Windows.Forms.TextBox();
            this.dersAd = new System.Windows.Forms.TextBox();
            this.dersKredi = new System.Windows.Forms.TextBox();
            this.ders_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ders Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kredi";
            // 
            // dersKod
            // 
            this.dersKod.Location = new System.Drawing.Point(129, 57);
            this.dersKod.Name = "dersKod";
            this.dersKod.Size = new System.Drawing.Size(100, 20);
            this.dersKod.TabIndex = 0;
            // 
            // dersAd
            // 
            this.dersAd.Location = new System.Drawing.Point(129, 94);
            this.dersAd.Name = "dersAd";
            this.dersAd.Size = new System.Drawing.Size(100, 20);
            this.dersAd.TabIndex = 1;
            // 
            // dersKredi
            // 
            this.dersKredi.Location = new System.Drawing.Point(129, 131);
            this.dersKredi.Name = "dersKredi";
            this.dersKredi.Size = new System.Drawing.Size(100, 20);
            this.dersKredi.TabIndex = 2;
            // 
            // ders_ekle
            // 
            this.ders_ekle.Location = new System.Drawing.Point(93, 193);
            this.ders_ekle.Name = "ders_ekle";
            this.ders_ekle.Size = new System.Drawing.Size(75, 23);
            this.ders_ekle.TabIndex = 3;
            this.ders_ekle.Text = "EKLE";
            this.ders_ekle.UseVisualStyleBackColor = true;
            this.ders_ekle.Click += new System.EventHandler(this.ders_ekle_Click);
            // 
            // ders_ac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ders_ekle);
            this.Controls.Add(this.dersKredi);
            this.Controls.Add(this.dersAd);
            this.Controls.Add(this.dersKod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ders_ac";
            this.Text = "Ders Açma Ekranı";
            this.Load += new System.EventHandler(this.ders_ac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dersKod;
        private System.Windows.Forms.TextBox dersAd;
        private System.Windows.Forms.TextBox dersKredi;
        private System.Windows.Forms.Button ders_ekle;
    }
}