using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using IngilizcePerformansBLL.Class;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace IngilizcePerformanYonetimUygulamasi
{
    public partial class AnaFrm : Form
    {
        public AnaFrm()
        {
            InitializeComponent();
        }

        public int girisYapanKisiId { get; set; }


        KonuAnlatimiBLL konuAnlatimiBLL;
        LabelYazdırmaBLL labelYazdırmaBLL;
        SoruBLL soruBLL;
        KonuBLL konuBLL;
        TestBLL testBLL;
        SesCalmaClassBLL sesCalmaClassBLL = new SesCalmaClassBLL();


        TesteSoruEklemeFrm testeSoruEklemeFrm;
        OpenFileDialog open;
        TestEkleUC testEkleUC;
        EklenenSoruUC eklenenSoruUC;
        List<int> SoruIdler = new List<int>();
        string resimYolu = "";
        bool openDoluMu = false;

        private void AnaFrm_Load(object sender, EventArgs e)
        {
            labelYazdırmaBLL = new LabelYazdırmaBLL();
            girisYapanKisi_lbl.Text = labelYazdırmaBLL.GirisYapanKisiLblYazdırma(girisYapanKisiId);
            grammarEkle_pnl.Visible = false;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icerikEkle_btn_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            toolStripDropDownButton1.Visible = true;
            konuBLL = new KonuBLL();
            konuSecme_cmb.DataSource = konuBLL.GetAllByExpression();
            konuSecme_cmb.DisplayMember = "Konu_Ismi";
            konuSecme_cmb.ValueMember = "Id";
            konuSecme_cmb.Invalidate();
            grammarEkle_pnl.Visible = true;
            button2.Location = new Point(icerikEkle_btn.Location.X + icerikEkle_btn.Size.Width + 8, icerikEkle_btn.Location.Y);
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            toolStripDropDownButton1.Visible = false;
            grammarEkle_pnl.Visible = false;
            button2.Location = new Point(Home_btn.Location.X + Home_btn.Size.Width + 8, Home_btn.Location.Y);
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            //BLLClass1.FormuTamEkranYapma(this);
            
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                icerik_txt.Size = new Size(icerik_txt.Width, icerik_txt.Height + 40);
                resimEkle_btn.Location = new Point(resimEkle_btn.Location.X, resimEkle_btn.Location.Y + 20);
                olustur_btn.Location = new Point(olustur_btn.Location.X, olustur_btn.Location.Y + 20);
                //dosyaYolu_txt.Location = new Point(dosyaYolu_txt.Location.X, dosyaYolu_txt.Location.Y - 20);
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                icerik_txt.Size = new Size(icerik_txt.Width, icerik_txt.Height - 40);
                resimEkle_btn.Location = new Point(resimEkle_btn.Location.X, resimEkle_btn.Location.Y - 20);
                olustur_btn.Location = new Point(olustur_btn.Location.X, olustur_btn.Location.Y - 20);
                //dosyaYolu_txt.Location = new Point(dosyaYolu_txt.Location.X, dosyaYolu_txt.Location.Y - 20);
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            //BLLClass1.FormuSimgeDurumunaKucultme(this);
        }

        private void resimEkle_btn_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            konuAnlatimiBLL = new KonuAnlatimiBLL();
            openDoluMu = open.ShowDialog() == DialogResult.OK;
        }

        private void olustur_btn_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            konuBLL = new KonuBLL();
            konuAnlatimiBLL = new KonuAnlatimiBLL();
            int grammarSayisi = konuAnlatimiBLL.GetAllByExpression(x => x.Grammar_KonuId == (int)konuSecme_cmb.SelectedValue).Count;

            konuBLL = new KonuBLL()
            {
                GuncellenecekKonuId = (int)konuSecme_cmb.SelectedValue,
                GrammarSayisi = grammarSayisi + 1
            };

            konuAnlatimiBLL = new KonuAnlatimiBLL()
            {
                Icerik = icerik_txt.Text,
                KonuId = (int)konuSecme_cmb.SelectedValue,
                ResimYolu = resimYolu
            };

            bool basariliMi = konuAnlatimiBLL.AddData();            
            string dosyaIsmi = konuBLL.GetDataByExpression(x => x.Id == (int)konuSecme_cmb.SelectedValue).Konu_Ismi + "_" + konuAnlatimiBLL.GetAllByExpression().Last().Id;

            if (openDoluMu)
            {
                resimYolu = konuAnlatimiBLL.AddPicture(open.FileName, (int)konuSecme_cmb.SelectedValue, dosyaIsmi);
            }

            konuAnlatimiBLL = new KonuAnlatimiBLL()
            {
                Icerik = icerik_txt.Text,
                KonuId = (int)konuSecme_cmb.SelectedValue,
                ResimYolu = resimYolu,
                GuncellenecekKonuAnlatimiId = konuAnlatimiBLL.GetAllByExpression().Last().Id
            };

            if (konuAnlatimiBLL.UpdateData() && konuBLL.UpdateData() && basariliMi)
            {
                MessageBox.Show("başarılı");
            }
            else
            {
                MessageBox.Show("başarısız");
            }
        }

        private void testEkle_menuItem_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            grammarEkle_pnl.Visible = false;
            toolStripDropDownButton1.Text = "Test Ekle";
            testEkleUC = new TestEkleUC();
            if (!Controls.Contains(testEkleUC))
            {
                testEkleUC.soruEkle_btn.Click += new EventHandler(soruEkle_btn_Click);
                testEkleUC.olustur_btn.Click += new EventHandler(testOlustur_btn_Click);
                testEkleUC.Location = grammarEkle_pnl.Location;
                testEkleUC.Dock = DockStyle.Fill;
                panel2.Controls.Add(testEkleUC);
            }
        }

        private void soruEkle_btn_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            ns1.BunifuThinButton2 soruEkle_btn = sender as ns1.BunifuThinButton2;
            TestEkleUC testEkleUC = soruEkle_btn.Parent as TestEkleUC;
            testeSoruEklemeFrm = new TesteSoruEklemeFrm();
            testeSoruEklemeFrm.FormClosing += new FormClosingEventHandler(TesteSoruEklemeFrm_Closing);
            testeSoruEklemeFrm.Show();
            this.Hide();
        }

        private void testOlustur_btn_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            ns1.BunifuThinButton2 testOlustur_btn = sender as ns1.BunifuThinButton2;
            TestEkleUC testEkleUC = testOlustur_btn.Parent as TestEkleUC;

            int sinavSuresi = 0;
            if (testEkleUC.sinavIsim_txt.Visible)           
                sinavSuresi = Convert.ToInt32(testEkleUC.sinavSure_txt.Text);
            
            int konuSecme_cmb_SelectedValue = Convert.ToInt32(testEkleUC.konuSecme_cmb.SelectedValue);


            soruBLL = new SoruBLL();

            if (testEkleUC.sinavIsim_txt.Visible)            
                testBLL = new TestBLL() { Isim = testEkleUC.sinavIsim_txt.Text, KonuId = (int)testEkleUC.konuSecme_cmb.SelectedValue, Sure = sinavSuresi, SoruSayisi = testEkleUC.eklenenSorular_flwpnl.Controls.Count };
            
            else            
                testBLL = new TestBLL() { Isim = testEkleUC.konuSecme_cmb.SelectedText + " - Konu Kavrama Testi - ", KonuId = (int)testEkleUC.konuSecme_cmb.SelectedValue, Sure = sinavSuresi, SoruSayisi = testEkleUC.eklenenSorular_flwpnl.Controls.Count };

            bool islemBasariliMi = testBLL.AddData();

            foreach (EklenenSoruUC soru in testEkleUC.eklenenSorular_flwpnl.Controls)
            {
                soruBLL.Icerik = soru.Icerik;
                soruBLL.SinavId = testBLL.Id;
                soruBLL.KonuId = soru.KonuId;
                soruBLL.GuncellenecekSoruId = soruBLL.GetDataByExpression(x => x.Soru_SinavId == soru.SinavId && x.Soru_KonuId == soru.KonuId && x.Soru_Icerik == soru.Icerik).Id;
                islemBasariliMi = soruBLL.UpdateData();
            }

            if (islemBasariliMi)
                islemSureci_tslbl.Text = "Test ekleme işlemi başarılı";
            else
                islemSureci_tslbl.Text = "Test ekleme işlemi başarısız tekrar deneyin";
        }

        private void konuAnlatımıEkle_menuItem_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            toolStripDropDownButton1.Text = "Konu Anlatımı Ekle";
            grammarEkle_pnl.Visible = true;
        }

        private void TesteSoruEklemeFrm_Closing(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            this.Show();
            soruBLL = new SoruBLL();
            konuBLL = new KonuBLL();

            SoruIdler = testeSoruEklemeFrm.SoruIdler;
            List<int> soruKonuIdler = new List<int>();
            List<string> konuIsimler = new List<string>();
            int f = 0;
            int g = 0;
            int y = 0;
            for (int i = 0; i< SoruIdler.Count; i++)
            {
                f = SoruIdler[i];
                soruKonuIdler.Add(soruBLL.GetDataByExpression(x => x.Id == f).Soru_KonuId);
                g = soruKonuIdler[i];
                konuIsimler.Add(konuBLL.GetDataByExpression(x => x.Id == g).Konu_Ismi);
            }

            for (int i = 0; i < SoruIdler.Count; i++)
            {
                y = SoruIdler[i];
                eklenenSoruUC = new EklenenSoruUC();
                eklenenSoruUC.konu_lbl.Text = konuIsimler[i];
                eklenenSoruUC.KonuId = soruKonuIdler[i];
                eklenenSoruUC.Icerik = soruBLL.GetDataByExpression(x => x.Id == y).Soru_Icerik;
                eklenenSoruUC.SinavId = soruBLL.GetDataByExpression(x => x.Id == y).Soru_SinavId;
                eklenenSoruUC.soruSirasi_lbl.Text = (testEkleUC.eklenenSorular_flwpnl.Controls.Count + 1).ToString();
                eklenenSoruUC.ozellikler_btn.Visible = true;
                eklenenSoruUC.sil_btn.Visible = true;
                testEkleUC.eklenenSorular_flwpnl.Controls.Add(eklenenSoruUC);
            }
        }

        private void konuSecme_cmb_Click(object sender, EventArgs e)
        {
            
        }

        private void girisYapanKisi_pctrbx_Click(object sender, EventArgs e)
        {

        }
    }
}
