using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using IngilizcePerformansBLL.Class;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngilizcePerformanYonetimUygulamasi
{
    public partial class TestEkleUC : UserControl
    {
        public TestEkleUC()
        {
            InitializeComponent();
        }

        KonuBLL konuBLL;
        SinifBLL sinifBLL;

        private void soruEkle_btn_Click(object sender, EventArgs e)
        {

        }

        private void olustur_btn_Click(object sender, EventArgs e)
        {

        }

        private void sinavTuru_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sinavTuru_cmb.SelectedIndex == 1)
            {
                sinavSure_txt.Visible = true;
                sinavIsim_txt.Visible = true;
            }
            else
            {
                sinavSure_txt.Visible = false;
                sinavIsim_txt.Visible = false;
            }
        }

        private void konuSecme_cmb_Click(object sender, EventArgs e)
        {

        }

        private void TestEkleUC_Load(object sender, EventArgs e)
        {
            konuBLL = new KonuBLL();
            sinifBLL = new SinifBLL();

            sinavTuru_cmb.SelectedIndex = 1;
            konuSecme_cmb.DataSource = konuBLL.GetAllByExpression();
            konuSecme_cmb.DisplayMember = "Konu_Ismi";
            konuSecme_cmb.ValueMember = "Id";
            konuSecme_cmb.Invalidate();
            sinavSube_cmb.DataSource = sinifBLL.GetAllByExpression();
            sinavSube_cmb.DisplayMember = "Sinif_TamIsim";
            sinavSube_cmb.ValueMember = "Id";
            sinavSube_cmb.Invalidate();
            konuSecme_cmb.Text = "Konu Seçiniz";
            sinavSube_cmb.Text = "Şube Seçiniz";
        }

        private void sinavIsim_txt_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sinavIsim_txt.Text == "")
            {
                sinavIsim_txt.Text = "Sınav İsmi Giriniz";
            }
        }

        private void sinavIsim_txt_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sinavIsim_txt.Text == "Sınav İsmi Giriniz")
            {
                sinavIsim_txt.Text = "";
            }
        }

        private void sinavSure_txt_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sinavSure_txt.Text == "")
            {
                sinavSure_txt.Text = "Sınav Süresi Giriniz";
            }
        }

        private void sinavSure_txt_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sinavSure_txt.Text == "Sınav Süresi Giriniz")
            {
                sinavSure_txt.Text = "";
            }
        }
    }
}
