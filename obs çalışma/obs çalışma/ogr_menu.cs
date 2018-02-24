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
    public partial class ogr_menu : Form
    {
        public ogr_menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ders_ekle ekle = new ders_ekle();
            ekle.ShowDialog();
            
        }

        private void ogr_menu_Load(object sender, EventArgs e)
        {
            using(var baglan=new OBSEntities2())
            {
                var sorgu = (from a in baglan.ogrenci
                             where a.no == giris_ekran.giden_numara
                             select a).SingleOrDefault();

                var ders_sorgu = (from i in baglan.ders_alir
                                  where i.ogrenci_no == sorgu.no
                                  select new
                                  {
                                      i.ders.ad,
                                      i.ders_kod,
                                      i.vize_not,
                                      i.final_not
                                  }            
                                  ).ToList();
                var danis_sorgu = baglan.ogretmen.Where(s => s.id == sorgu.danisman_id).FirstOrDefault();
                var bolum_sorgu = baglan.bolum.Where(s => s.id == sorgu.bolum_id).FirstOrDefault();

                lblisim.Text = sorgu.ad;
                lblsoyad.Text = sorgu.soyad;
                lbltc.Text = sorgu.tc;
                lblnumara.Text = sorgu.no;
                lbldanısman.Text = danis_sorgu.ad + " " + danis_sorgu.soyad;
                lblbolum.Text = bolum_sorgu.ad;

                dgw_ders_liste.DataSource =ders_sorgu;

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var baglan = new OBSEntities2())
            {
                var sil = (from s in baglan.ogrenci
                           where s.no == giris_ekran.giden_numara
                           select s).FirstOrDefault();
                //burada şartı sağlayan tüm kayıtları sildim.
                baglan.ders_alir.RemoveRange(baglan.ders_alir.Where(x => x.ogrenci_no == giris_ekran.giden_numara));
                baglan.SaveChanges();

                baglan.Entry(sil).State = System.Data.Entity.EntityState.Deleted;
                baglan.SaveChanges();
                giris_ekran giris = new giris_ekran();
                giris.Show();
                this.Close();
            }
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            using (var baglan = new OBSEntities2())
            {
                var sorgu = (from a in baglan.ogrenci
                             where a.no == giris_ekran.giden_numara
                             select a).SingleOrDefault();

                var ders_sorgu = (from i in baglan.ders_alir
                                  where i.ogrenci_no == sorgu.no
                                  select new
                                  {
                                      i.ders.ad,
                                      i.ders_kod,
                                      i.vize_not,
                                      i.final_not
                                  }
                                  ).ToList();
                var danis_sorgu = baglan.ogretmen.Where(s => s.id == sorgu.danisman_id).FirstOrDefault();
                var bolum_sorgu = baglan.bolum.Where(s => s.id == sorgu.bolum_id).FirstOrDefault();

                lblisim.Text = sorgu.ad;
                lblsoyad.Text = sorgu.soyad;
                lbltc.Text = sorgu.tc;
                lblnumara.Text = sorgu.no;
                lbldanısman.Text = danis_sorgu.ad + " " + danis_sorgu.soyad;
                lblbolum.Text = bolum_sorgu.ad;

                dgw_ders_liste.DataSource = ders_sorgu;

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            giris_ekran ge = new giris_ekran();
            ge.Show();
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
