using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_ödevim
{
     abstract class Hayvan : ISatYemVer
     {
        //Keçi inek tavuk ve ördek classında kullanacağım Can metodunun temelini atıyorum.
        public  virtual  void Can(ProgressBar HayvanCani, Timer timer,Timer timer2, Label HayvanCan)
        {
        }
        //Tüm hayvanlarda aynı işlevi göreceği için Hayvan classına yazdığım metod
        public void YemVer(ProgressBar HayvanCani)
        {
            //Hayvanın canı 0 değilse canını dolduran koşul
            if (HayvanCani.Value != 0)
            {
                HayvanCani.Value = 100;
            }
            //Hayvan ölü olduğu halde beslenmeye çalışılırsa ortaya çıkacak olan mesaj kutusu.
            if (HayvanCani.Value == 0)
            {
                MessageBox.Show("Ölü Hayvanı Besleyemezsin!");
            }
        }
     }
}
