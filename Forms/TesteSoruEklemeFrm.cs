using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using IngilizcePerformansBLL.Class;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngilizcePerformanYonetimUygulamasi
{
    public partial class TesteSoruEklemeFrm : Form
    {
        public TesteSoruEklemeFrm()
        {
            InitializeComponent();
        }

        class ListelenenSoru_btn : Button
        {
            public string SoruIcerik { get; set; }
            public List<string> SoruSecenekler { get; set; }
            public int SoruId { get; set; }
        }

        public List<int> SoruIdler { get; set; }

        ComboBox konuyaGoreSorgulama_cmb;
        TextBox ismeGoreSorgulama_txt;
        ComboBox sinifDuzeyineGoreSorgulama_cmb;
        SesCalmaClassBLL sesCalmaClassBLL = new SesCalmaClassBLL();
        KonuBLL konuBLL;
        SoruBLL soruBLL;
        TestBLL testBLL;
        SinifBLL sinifBLL;
        SecenekBLL secenekBLL;
        int secilenSoruId;
        int labelSayac = 0;
        List<int> sinifDuzeyleri = new List<int>();

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TesteSoruEklemeFrm_Load(object sender, EventArgs e)
        {
            listelenenSorular_flwpnl.AutoScroll = true;
            soruIcerik_txt.Visible = false;
            listelenenSorular_flwpnl.HorizontalScroll.Visible = false;
            labelSayaci_tmr.Tick += new EventHandler(labelSayaci_tmr_Tick);
            SoruIdler = new List<int>();
        }

        private void konuSecme_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            konuBLL = new KonuBLL();
            sinifBLL = new SinifBLL();
            sorgulamaControlleri_pnl.Controls.Clear();
            if (konuSecme_cmb.SelectedIndex == 0)
            {
                konuyaGoreSorgulama_cmb = new ComboBox();
                konuyaGoreSorgulama_cmb.Location = new Point(0, 5);
                konuyaGoreSorgulama_cmb.SelectedIndexChanged += new EventHandler(konuyaGoreSorgulama_cmb_SelectedIndexChanged);
                konuyaGoreSorgulama_cmb.Size = new Size(sorgulamaControlleri_pnl.Width, konuyaGoreSorgulama_cmb.Height);
                konuyaGoreSorgulama_cmb.FlatStyle = FlatStyle.Flat;
                konuyaGoreSorgulama_cmb.Font = konuSecme_cmb.Font;
                konuyaGoreSorgulama_cmb.BackColor = konuSecme_cmb.BackColor;
                konuyaGoreSorgulama_cmb.DataSource = konuBLL.GetAllByExpression();
                konuyaGoreSorgulama_cmb.DisplayMember = "Konu_Ismi";
                konuyaGoreSorgulama_cmb.ValueMember = "Id";
                konuyaGoreSorgulama_cmb.Invalidate();
                sorgulamaControlleri_pnl.Controls.Add(konuyaGoreSorgulama_cmb);
                konuyaGoreSorgulama_cmb.Text = "Konu Seçiniz";
            }

            if (konuSecme_cmb.SelectedIndex == 1)
            {
                ismeGoreSorgulama_txt = new TextBox();
                listelenenSorular_flwpnl.Visible = false;
                secenekler_flwpnl.Visible = false;
                soruIcerik_txt.Visible = false;
                ismeGoreSorgulama_txt.Text = "Konu İsmi Giriniz";
                ismeGoreSorgulama_txt.Location = new Point(0, 8);
                ismeGoreSorgulama_txt.TextChanged += new EventHandler(ismeGoreSecme_txt_TextChanged);
                ismeGoreSorgulama_txt.Size = new Size(sorgulamaControlleri_pnl.Width, sorgulamaControlleri_pnl.Height);
                ismeGoreSorgulama_txt.Font = soruIcerik_txt.Font;
                ismeGoreSorgulama_txt.BackColor = konuSecme_cmb.BackColor;
                sorgulamaControlleri_pnl.Controls.Add(ismeGoreSorgulama_txt);
            }

            if (konuSecme_cmb.SelectedIndex == 2)
            {
                sinifDuzeyineGoreSorgulama_cmb = new ComboBox();
                foreach (var item in sinifBLL.GetAllByExpression())
                {
                    if (!sinifDuzeyleri.Contains(item.Sinif_DuzeyId))
                    {
                        sinifDuzeyleri.Add(item.Sinif_DuzeyId);
                    }
                }
                sinifDuzeyineGoreSorgulama_cmb.Location = new Point(0, 5);
                sinifDuzeyineGoreSorgulama_cmb.SelectedIndexChanged += new EventHandler(sinifDuzeyineGoreSorgulama_cmb_SelectedIndexChanged);
                sinifDuzeyineGoreSorgulama_cmb.Size = new Size(sorgulamaControlleri_pnl.Width, konuyaGoreSorgulama_cmb.Height);
                sinifDuzeyineGoreSorgulama_cmb.FlatStyle = FlatStyle.Flat;
                sinifDuzeyineGoreSorgulama_cmb.Font = konuSecme_cmb.Font;
                sinifDuzeyineGoreSorgulama_cmb.BackColor = konuSecme_cmb.BackColor;
                sinifDuzeyineGoreSorgulama_cmb.DataSource = sinifDuzeyleri;
            }
        }

        private void ismeGoreSecme_txt_TextChanged(object sender, EventArgs e)
        {
            soruBLL = new SoruBLL();
            testBLL = new TestBLL();
            secenekBLL = new SecenekBLL();
            ListelenenSoru_btn button;
            int sayac = 1;

            secenekler_flwpnl.Visible = true;
            listelenenSorular_flwpnl.Visible = true;
            soruIcerik_txt.Visible = true;

            listelenenSorular_flwpnl.Controls.Clear();
            foreach (var test in testBLL.GetAllByExpression(x => x.Sinav_Ismi.Contains(ismeGoreSorgulama_txt.Text)))
            {
                foreach (var soru in soruBLL.GetAllByExpression(x => x.Soru_SinavId == test.Id))
                {
                    button = new ListelenenSoru_btn();
                    button.SoruIcerik = soru.Soru_Icerik;
                    button.SoruSecenekler = new List<string>();
                    button.SoruId = soru.Id;
                    foreach (var secenek in secenekBLL.GetAllByExpression(x => x.Secenek_SoruId == soru.Id))
                    {
                        button.SoruSecenekler.Add(secenek.Secenek_Ismi + " ) " + secenek.Secenek_Icerik);
                    }
                    button.Text = testBLL.GetDataByExpression(x => x.Id == soru.Soru_SinavId).Sinav_Ismi + " - " + sayac.ToString() + ". Soru";
                    button.Size = new Size(185, 100);
                    button.FlatAppearance.BorderSize = 2;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Click += new EventHandler(listelenenSoru_btn_Click);
                    button.FlatAppearance.BorderColor = Color.FromArgb(150, 150, 150);
                    button.BackColor = Color.FromArgb(0, 133, 181);
                    button.ForeColor = Color.Silver;
                    button.Font = konuSecme_cmb.Font;
                    listelenenSorular_flwpnl.Controls.Add(button);
                    sayac++;
                }
                sayac = 1;
            }
        }

        private void konuyaGoreSorgulama_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            soruBLL = new SoruBLL();
            testBLL = new TestBLL();
            secenekBLL = new SecenekBLL();
            ListelenenSoru_btn button;
            short sayac = 1;

            secenekler_flwpnl.Visible = true;
            listelenenSorular_flwpnl.Visible = true;
            soruIcerik_txt.Visible = true;

            listelenenSorular_flwpnl.Controls.Clear();
            foreach (var soru in soruBLL.GetAllByExpression(x => x.Soru_KonuId == (int)konuyaGoreSorgulama_cmb.SelectedValue))
            {
                button = new ListelenenSoru_btn();
                button.SoruIcerik = soru.Soru_Icerik;
                button.SoruSecenekler = new List<string>();
                button.SoruId = soru.Id;
                foreach (var secenek in secenekBLL.GetAllByExpression(x => x.Secenek_SoruId == soru.Id))
                {
                    button.SoruSecenekler.Add(secenek.Secenek_Ismi + " ) " + secenek.Secenek_Icerik);
                }
                button.Text = testBLL.GetDataByExpression(x => x.Id == soru.Soru_SinavId).Sinav_Ismi + " " + sayac.ToString() + ". Soru";
                button.Size = new Size(190, 60);
                button.FlatAppearance.BorderSize = 2;
                button.FlatStyle = FlatStyle.Flat;
                button.Click += new EventHandler(listelenenSoru_btn_Click);
                button.FlatAppearance.BorderColor = Color.FromArgb(150, 150, 150);
                button.BackColor = sorgulamaCümlesi_lbl.ForeColor;
                button.ForeColor = Color.Silver;
                button.Font = konuyaGoreSorgulama_cmb.Font;
                listelenenSorular_flwpnl.Controls.Add(button);
                sayac++;
            }
            sayac = 1;
        }

        private void sinifDuzeyineGoreSorgulama_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listelenenSoru_btn_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            ListelenenSoru_btn listelenenSoru_btn = sender as ListelenenSoru_btn;
            TextBox secenek_txt;

            secilenSoruId = listelenenSoru_btn.SoruId;
            soruIcerik_txt.Text = listelenenSoru_btn.SoruIcerik;
            soruIcerik_txt.Visible = true;
            soruIcerik_txt.ReadOnly = true;
            secenekler_flwpnl.Controls.Clear();
            foreach (string secenek in listelenenSoru_btn.SoruSecenekler)
            {
                secenek_txt = new TextBox();
                secenek_txt.Multiline = true;
                secenek_txt.Text = secenek;
                secenek_txt.Size = new Size(210, 50);
                secenek_txt.ReadOnly = true;
                secenek_txt.BackColor = Color.FromArgb(220, 220, 220);
                secenek_txt.Font = soruIcerik_txt.Font;
                secenekler_flwpnl.Controls.Add(secenek_txt);
            }
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            WindowState = FormWindowState.Maximized;
        }

        private void soruEkle_btn_Click(object sender, EventArgs e)
        {
            sesCalmaClassBLL.PlayClickSound();
            labelSayac = 0;
            if (SoruIdler.Contains(secilenSoruId))
            {
                if (labelSayaci_tmr.Enabled)
                {
                    labelSayaci_tmr.Stop();
                    labelSayaci_tmr.Start();
                }
                else
                {
                    labelSayaci_tmr.Start();
                }
                label2.Text = "Bu soru zaten eklendi";
                label2.ForeColor = Color.FromArgb(50,50,50);
                label2.Visible = true;
            }
            else
            {
                if (labelSayaci_tmr.Enabled)
                {
                    labelSayaci_tmr.Stop();
                    labelSayaci_tmr.Start();
                }
                else
                {
                    labelSayaci_tmr.Start();
                }
                SoruIdler.Add(secilenSoruId);
                label2.Text = "Soru başarıyla eklendi";
                label2.ForeColor = Color.DarkGreen;
                label2.Visible = true;
            }
        }

        private void labelSayaci_tmr_Tick(object sender, EventArgs e)
        {
            labelSayac++;
            if (labelSayac == 40)
            {
                label2.Visible = false;
                labelSayaci_tmr.Stop();
            }
        }
    }
}
