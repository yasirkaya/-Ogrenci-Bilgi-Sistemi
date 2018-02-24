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
    public partial class ders_ac : Form
    {
        public ders_ac()
        {
            InitializeComponent();
        }

        private void ders_ekle_Click(object sender, EventArgs e)
        {
            using (var context =new OBSEntities2())
            {
                var varMiKod = context.ders.Where(v => v.kod == dersKod.Text).Any();
                var varMiAd = context.ders.Where(v1 => v1.ad == dersAd.Text).Any();

                if(varMiAd || varMiKod)
                {
                    MessageBox.Show("Girilen kod veya isimde ders bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dersAd.Clear();
                    dersKod.Clear();
                    dersKredi.Clear();
                }
                else
                {
                    ders newders =new ders();
                    newders.kod = dersKod.Text;
                    newders.ad = dersAd.Text;
                    newders.kredi =Convert.ToDecimal(dersKredi.Text);
                    newders.ogretmen_id = giris_ekran.giden_user;

                    context.ders.Add(newders);
                    context.SaveChanges();
                    this.Close();
                }

                
            }
        }

        private void ders_ac_Load(object sender, EventArgs e)
        {

        }
    }
}
