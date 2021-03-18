using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngilizcePerformanYonetimUygulamasi
{
    public partial class EklenenSoruUC : UserControl
    {
        public EklenenSoruUC()
        {
            InitializeComponent();
        }

        public string Icerik { get; set; }
        public int KonuId { get; set; }
        public int SinavId { get; set; }
    }
}
