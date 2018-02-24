using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace obs_çalışma
{
    public partial class giris_ekran : Form
    {
        public giris_ekran()
        {
            InitializeComponent();
        }
        public static string giden_numara;
        public static string giden_user;
        private void btn_ogrenci_Click(object sender, EventArgs e)
        {
            using(var baglan =new OBSEntities2())
            {
                var sorgu = (from s in baglan.ogrenci where s.no==txtNumara.Text select s.no).Any();
                if (!sorgu)
                {
                    MessageBox.Show("Öğrenci Bulunamadı.\nYeniden deneyin veya yeni kayıt oluşturun.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtNumara.Clear();
                    txtNumara.Focus();

                }
                else
                {
                    giden_numara = txtNumara.Text;
                    ogr_menu menu = new ogr_menu();
                    menu.Show();
                    this.Hide();
                }
            }
            
           
        }

        private void giris_ekran_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            yeni_kayit yk = new yeni_kayit();
            yk.ShowDialog();
            
        }

        private void btn_ogretmen_Click(object sender, EventArgs e)
        {

            using (var context = new OBSEntities2())
            {
                var kosul = context.ogretmen.Where(k => k.id == txtuser.Text).Any();
                if (!kosul)
                {
                    MessageBox.Show("Öğretmen Bulunamadı.\nYeniden deneyin.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtuser.Clear();
                    txtuser.Focus();
                }
                else
                {
                    giden_user = txtuser.Text;
                    ogretmen_menu ogrmenu = new ogretmen_menu();
                    ogrmenu.Show();
                    this.Hide();
                }
            }






           

        }

        private void giris_ekran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
