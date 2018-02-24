namespace obs_çalışma
{
    partial class not_girme
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
            this.ogr_no = new System.Windows.Forms.TextBox();
            this.ders_kd = new System.Windows.Forms.TextBox();
            this.al_not = new System.Windows.Forms.TextBox();
            this.vize_not = new System.Windows.Forms.Button();
            this.final_not = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ders Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Not";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ogr_no
            // 
            this.ogr_no.Location = new System.Drawing.Point(109, 39);
            this.ogr_no.Name = "ogr_no";
            this.ogr_no.Size = new System.Drawing.Size(100, 20);
            this.ogr_no.TabIndex = 1;
            // 
            // ders_kd
            // 
            this.ders_kd.Location = new System.Drawing.Point(109, 74);
            this.ders_kd.Name = "ders_kd";
            this.ders_kd.Size = new System.Drawing.Size(100, 20);
            this.ders_kd.TabIndex = 1;
            // 
            // al_not
            // 
            this.al_not.Location = new System.Drawing.Point(109, 113);
            this.al_not.Name = "al_not";
            this.al_not.Size = new System.Drawing.Size(100, 20);
            this.al_not.TabIndex = 1;
            this.al_not.TextChanged += new System.EventHandler(this.al_not_TextChanged);
            // 
            // vize_not
            // 
            this.vize_not.Location = new System.Drawing.Point(26, 175);
            this.vize_not.Name = "vize_not";
            this.vize_not.Size = new System.Drawing.Size(75, 23);
            this.vize_not.TabIndex = 2;
            this.vize_not.Text = "VİZE";
            this.vize_not.UseVisualStyleBackColor = true;
            this.vize_not.Click += new System.EventHandler(this.vize_not_Click);
            // 
            // final_not
            // 
            this.final_not.Location = new System.Drawing.Point(148, 175);
            this.final_not.Name = "final_not";
            this.final_not.Size = new System.Drawing.Size(75, 23);
            this.final_not.TabIndex = 2;
            this.final_not.Text = "FİNAL";
            this.final_not.UseVisualStyleBackColor = true;
            this.final_not.Click += new System.EventHandler(this.final_not_Click);
            // 
            // not_girme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 262);
            this.Controls.Add(this.final_not);
            this.Controls.Add(this.vize_not);
            this.Controls.Add(this.al_not);
            this.Controls.Add(this.ders_kd);
            this.Controls.Add(this.ogr_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "not_girme";
            this.Text = "Not Gir";
            this.Load += new System.EventHandler(this.not_girme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ogr_no;
        private System.Windows.Forms.TextBox ders_kd;
        private System.Windows.Forms.TextBox al_not;
        private System.Windows.Forms.Button vize_not;
        private System.Windows.Forms.Button final_not;
    }
}