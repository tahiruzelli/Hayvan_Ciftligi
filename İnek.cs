using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace proje_ödevim
{
    class İnek : Hayvan
    {      
        
        public override void Can(ProgressBar İnekCani,Timer inektimer,Timer ineksut, Label İnekCan)
        {
            //Canının azalmasını sağlayan koşul
            if (İnekCani.Value <= 100)
            {
                İnekCani.Value -= 8;
            }
            //Hayvanı öldüren ve ses çıkartmasını sağlayan koşul
            if (İnekCani.Value == 4)
            {
                İnekCani.Value = 0;
                inektimer.Stop();
                ineksut.Stop();
                SoundPlayer İnekSes = new SoundPlayer();
                İnekSes.SoundLocation = "inek.wav";
                İnekSes.Play();
                İnekCan.Text = "ÖLÜ";
            }
        }
        public void MesajKutusu(Label IS)
        {
            //Eğer satacak ürün yoksa mesaj kutusu çıkmasını sağlayan koşul.
            if (IS.Text == "0")
            {
                MessageBox.Show("Satacak Sütün Yok!");
            }
        }

    }
}
