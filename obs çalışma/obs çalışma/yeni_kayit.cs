using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obs_çalışma
{
    public partial class yeni_kayit : Form
    {
        public yeni_kayit()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void k_ekle_Click(object sender, EventArgs e)
        {
            using(var baglan =new OBSEntities2())
            {
                if(txtNumara.Text.Length==9 && txtTc.Text.Length==11 && txtDanisman.Text.Length==5 && txtBolum.Text.Length == 3)
                {
                     ogrenci ogr = new ogrenci();
                    ogr.no = txtNumara.Text;
                    ogr.tc = txtTc.Text;
                    ogr.ad = txtAd.Text;
                    ogr.soyad = txtSoyad.Text;
                    ogr.danisman_id = txtDanisman.Text;
                    ogr.bolum_id = txtBolum.Text;
                    baglan.ogrenci.Add(ogr);
                    baglan.SaveChanges();
                    DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (sonuc == DialogResult.No)
                    {
                       
                        return;
                    }
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Lütfen istenilen koşulları yerine getirin!!!");
                    txtNumara.Clear();
                    txtTc.Clear();
                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtDanisman.Clear();
                    txtBolum.Clear();
                }
               
                
            }
        }

        private void k_ekle_Click_1(object sender, EventArgs e)
        {
            using (var baglan = new OBSEntities2())
            {
                if (txtNumara.Text.Length == 9 && txtTc.Text.Length == 11 && txtDanisman.Text.Length == 5 && txtBolum.Text.Length == 3)
                {
                    ogrenci ogr = new ogrenci();
                    ogr.no = txtNumara.Text;
                    ogr.tc = txtTc.Text;
                    ogr.ad = txtAd.Text;
                    ogr.soyad = txtSoyad.Text;
                    ogr.danisman_id = txtDanisman.Text;
                    ogr.bolum_id = txtBolum.Text;
                    baglan.ogrenci.Add(ogr);
                    baglan.SaveChanges();
                    this.Close();
                    //DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //if (sonuc == DialogResult.No)
                    //{

                    //    return;
                    //}
                    //Application.Exit();
                }
                else
                {
                    MessageBox.Show("Lütfen istenilen koşulları yerine getirin!!!");
                    txtNumara.Clear();
                    txtTc.Clear();
                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtDanisman.Clear();
                    txtBolum.Clear();
                }


            }
        }

        private void txtNumara_Click(object sender, EventArgs e)
        {
            txtNumara.Text = "";
        }

        private void txtTc_Click(object sender, EventArgs e)
        {
            txtTc.Text = "";
        }

        private void txtDanisman_Click(object sender, EventArgs e)
        {
            txtDanisman.Text = "";
        }

        private void txtBolum_Click(object sender, EventArgs e)
        {
            txtBolum.Text = "";
        }

        private void yeni_kayit_Load(object sender, EventArgs e)
        {

        }

        private void txtNumara_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
