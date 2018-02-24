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
    public partial class ogretmen_menu : Form
    {
        public ogretmen_menu()
        {
            InitializeComponent();
        }

        private void ogretmen_menu_Load(object sender, EventArgs e)
        {
            using(var context=new OBSEntities2())
            {
                var sorgu = (from s in context.ogretmen
                             where s.id == giris_ekran.giden_user
                             select s).FirstOrDefault();
                var bolumAdSorgu = context.bolum.Where(s => s.id == sorgu.bolum_id).FirstOrDefault();

                ad.Text = sorgu.ad;
                soyad.Text = sorgu.soyad;
                bolum.Text = bolumAdSorgu.ad;
            }
        }

        private void ders_ac_Click(object sender, EventArgs e)
        {
            ders_ac dersAc = new ders_ac();
            dersAc.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            not_girme ng = new not_girme();
            ng.Show();
            

        }

        private void exit_Click(object sender, EventArgs e)
        {
            giris_ekran ge = new giris_ekran();
            ge.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context =new OBSEntities2())
            {
                var silSorgu = (from s in context.ders
                                where s.kod==txt_silDers.Text
                                select s).FirstOrDefault();

                context.ders_alir.RemoveRange(context.ders_alir.Where(s => s.ders_kod == silSorgu.kod));

                context.Entry(silSorgu).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
