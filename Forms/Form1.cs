using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using IngilizcePerformansBLL.Class;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngilizcePerformanYonetimUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ingilizcePerformansVeritabaniDataSet.Konular' table. You can move, or remove it, as needed.
            //this.konularTableAdapter.Fill(this.ingilizcePerformansVeritabaniDataSet.Konular);

            /*SinifBLL sinifBLL = new SinifBLL();
            sinifBLL.SilinecekSinifId = 18;
            sinifBLL.DeleteData();*/

            TestBLL testBLL = new TestBLL();
            testBLL.GuncellenecekTestId = 22;
            testBLL.SoruSayisi = 1;
            testBLL.TestCozulduMu = true;
            testBLL.UpdateData();

            foreach (Button button in flowLayoutPanel1.Controls)
            {
                if (button.Name == "buton")
                {
                    button.ForeColor = Color.Green;
                }
            }
        }
    }
}
