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
    public partial class ders_ekle : Form
    {
        public ders_ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void ders_ekle_Load(object sender, EventArgs e)
        {
            using (var baglan=new OBSEntities2())
            {
                dgw_dersListe.DataSource = baglan.ders.Select(x=>new {x.kod,x.ad,x.kredi,x.ogretmen_id }).ToList();
               
            }

        }
        private void selectedRowsButton_Click(object sender, System.EventArgs e)
        {
            
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            using (var baglan1 = new OBSEntities2())
            {
                dgw_dersListe.MultiSelect = false;
                var selectedrow = dgw_dersListe.CurrentRow;
                string dersKod = selectedrow.Cells[0].Value.ToString();

                ders_alir dersAlir = new ders_alir();
                dersAlir.ogrenci_no = giris_ekran.giden_numara;
                dersAlir.ders_kod = dersKod;

                var varMı = (from s in baglan1.ders_alir
                             where s.ogrenci_no==giris_ekran.giden_numara &&s.ders_kod==dersAlir.ders_kod
                             select s.ders_kod).Any();

                if (varMı)
                {
                    MessageBox.Show("Seçilen ders zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    baglan1.ders_alir.Add(dersAlir);
                    baglan1.SaveChanges();
                    this.Close();
                }


                    
                
            }
        }
    }
}
