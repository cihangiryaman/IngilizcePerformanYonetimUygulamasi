using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using IngilizcePerformansBLL.Class;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngilizcePerformanYonetimUygulamasi
{
    public partial class GirisFrm : Form
    {
        public GirisFrm()
        {
            InitializeComponent();
        }

        SesCalmaClassBLL sesCalmaClassBLL = new SesCalmaClassBLL();
        OgretmenBLL ogretmenBLL;

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            sesCalmaClassBLL.PlayClickSound();
            ogretmenBLL = new OgretmenBLL()
            {
                KullaniciAdi = kullaniciAdi_txt.Text,
                Sifre = sifre_txt.Text
            };

            if (ogretmenBLL.CanLogIn())
            {
                AnaFrm anaFrm = new AnaFrm();
                anaFrm.girisYapanKisiId = ogretmenBLL.GirisYapanOgretmenId;
                this.Hide();
                anaFrm.Show();
            }
            else
            {
                kullaniciAdi_txt.LineIdleColor = Color.Red;
                kullaniciAdi_txt.LineFocusedColor = Color.Red;
                kullaniciAdi_txt.LineMouseHoverColor = Color.Red;
                sifre_txt.LineIdleColor = Color.Red;
                sifre_txt.LineFocusedColor = Color.Red;
                sifre_txt.LineMouseHoverColor = Color.Red;
            }
            label1.Visible = false;
        }
    }
}
