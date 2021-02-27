using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace IngilizcePerformanYonetimUygulamasi
{
    class SesCalmaClass
    {
        public void TiklamaSesiCalma()
        {
            SoundPlayer player = new SoundPlayer();
            player.Stream = TiklamaSesiCalmaRes.Mouse_Tıklama_Click_Ses_Efekti__320_kbps_;
            player.Play();
        }
    }
}
