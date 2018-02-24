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
    public partial class not_girme : Form
    {
        public not_girme()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void al_not_TextChanged(object sender, EventArgs e)
        {

        }

        private void vize_not_Click(object sender, EventArgs e)
        {

            ders_alir sorgu;
            using(var baglan=new OBSEntities2())
            {
                sorgu = (from s in baglan.ders_alir
                         where s.ogrenci_no == ogr_no.Text && s.ders_kod == ders_kd.Text
                         select s).FirstOrDefault();

            }
            if (sorgu != null)
            {
                Boolean varMi;
                using(var context1=new OBSEntities2())
                {
                    varMi = (from v in context1.ders
                                 where v.kod==sorgu.ders_kod && v.ogretmen_id==giris_ekran.giden_user
                                 select v).Any();
                }

                if (varMi)
                {
                    sorgu.vize_not = Convert.ToDecimal(al_not.Text);

                    using (var context = new OBSEntities2())
                    {
                        context.Entry(sorgu).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seçilen dersi vermiyorsunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {
                MessageBox.Show("Yanlış bilgi girdiniz tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
           
            


        }

        private void final_not_Click(object sender, EventArgs e)
        {
            ders_alir sorgu;
            using (var baglan = new OBSEntities2())
            {
                sorgu = (from s in baglan.ders_alir
                         where s.ogrenci_no == ogr_no.Text && s.ders_kod == ders_kd.Text
                         select s).FirstOrDefault();

            }
            if(sorgu != null)
            {
                Boolean varMi;
                using(var context1=new OBSEntities2())
                {
                    varMi = (from v in context1.ders
                            where v.kod == sorgu.ders_kod && v.ogretmen_id == giris_ekran.giden_user
                            select v).Any();
                }

                if (varMi)
                {
                    sorgu.final_not = Convert.ToDecimal(al_not.Text);

                    using (var context = new OBSEntities2())
                    {
                        context.Entry(sorgu).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seçilen dersi vermiyorsunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {
                MessageBox.Show("Yanlış bilgi girdiniz tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            

        }


        private void not_girme_Load(object sender, EventArgs e)
        {

        }
    }
}
