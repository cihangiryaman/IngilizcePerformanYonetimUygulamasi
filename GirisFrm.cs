using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using IngilizcePerformansDAL.Class;
using IngilizcePerformansDAL.Veritabani;
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

        bool dogruMu = true;

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            sesCalmaClassBLL.PlayClickSound();
            dogruMu = true;
            ogretmenBLL = new OgretmenBLL();
            Ogretmen ogretmen = new Ogretmen();

            ogretmen = ogretmenBLL.GetAllByExpression(x => x.Ogretmen_KullaniciAdi == kullaniciAdi_txt.Text && x.Ogretmen_Sifre == sifre_txt.Text).ToList().FirstOrDefault();

            if (ogretmen == null)
            {
                dogruMu = false;
            }
            /*try
            {
                
            }
            catch (InvalidOperationException)
            {
                dogruMu = false;
            }*/
            
            if (/*BLLVeritabaniIslemleriClass.GirisYapabilirMi(kullaniciAdi_txt,sifre_txt)*/dogruMu)
            {
                AnaFrm anaFrm = new AnaFrm();
                anaFrm.girisYapanKisiId = 1;//ogretmen.Id/*BLLVeritabaniIslemleriClass.OgretmenBilgileriGetir(kullaniciAdi_txt.Text).Id*/;
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
