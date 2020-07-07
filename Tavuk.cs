using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace proje_ödevim
{
    class Tavuk:Hayvan
    {     
        
        public override void Can(ProgressBar TavukCani, Timer tavuktimer,Timer TavukYumurta,Label TavukCan)
        {
            //Canının azalmasını sağlayan koşul
            if (TavukCani.Value <= 100)
            {
                TavukCani.Value -= 2;
            }
            //Hayvanı öldüren ve ses çıkartmasını sağlayan koşul
            if (TavukCani.Value == 0)
            {
                TavukCani.Value = 0;
                tavuktimer.Stop();
                TavukYumurta.Stop();
                SoundPlayer TavukSes = new SoundPlayer();
                TavukSes.SoundLocation = "tavuk.wav";
                TavukSes.Play();
                TavukCan.Text = "ÖLÜ";
            }
        }
        public void MesajKutusu(Label TY)
        {
            //Eğer satacak ürün yoksa mesaj kutusu çıkmasını sağlayan koşul.
            if (TY.Text == "0")
            {
                MessageBox.Show("Satacak Yumurtan Yok!");
            }
        }
    }
}
