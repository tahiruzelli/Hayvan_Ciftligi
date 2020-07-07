using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace proje_ödevim
{
    class Ordek:Hayvan
    {       
        
        public override void Can(ProgressBar OrdekCani, Timer Ordektimer,Timer Ordekyumurta,Label OrdekCan )
        {
            //Canının azalmasını sağlayan koşul
            if (OrdekCani.Value <= 100)
            {
                OrdekCani.Value -= 3;
            }
            //Hayvanı öldüren ve ses çıkartmasını sağlayan koşul
            if (OrdekCani.Value == 1)
            {
                OrdekCani.Value = 0;
                Ordektimer.Stop();
                Ordekyumurta.Stop();
                SoundPlayer OrdekSes = new SoundPlayer();
                OrdekSes.SoundLocation = "ordek.wav";
                OrdekSes.Play();
                OrdekCan.Text = "ÖLÜ";
            }
        }
        public void MesajKutusu(Label OY)
        {
            //Eğer satacak ürün yoksa mesaj kutusu çıkmasını sağlayan koşul.
            if (OY.Text == "0")
            {
                MessageBox.Show("Satacak Yumurtan Yok!");
            }
        }
    }
}
