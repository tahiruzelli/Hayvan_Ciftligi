using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace proje_ödevim
{
    class Keci:Hayvan
    {       
       
        public override void Can(ProgressBar KeciCani, Timer kecitimer,Timer kecisut,Label KeciCan)
        {
            //Canının azalmasını sağlayan koşul
            if (KeciCani.Value <= 100)
            {
                KeciCani.Value -= 6;
            }
            //Hayvanı öldüren ve ses çıkartmasını sağlayan koşul
            if (KeciCani.Value == 4)
            {
                KeciCani.Value = 0;
                kecitimer.Stop();
                kecisut.Stop();
                SoundPlayer KeciSes = new SoundPlayer();
                KeciSes.SoundLocation = "Keci.wav";
                KeciSes.Play();
                KeciCan.Text = "ÖLÜ";
            }
        }
        public void MesajKutusu(Label KS)
        {
            //Eğer satacak ürün yoksa mesaj kutusu çıkmasını sağlayan koşul.
            if (KS.Text == "0")
            {
                MessageBox.Show("Satacak Sütün Yok!");
            }
        }
    }
}
