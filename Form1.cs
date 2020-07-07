using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace proje_ödevim
{
    public partial class Form1 : Form
    {
        //kullanacağım değişken ve nesneler
        private double sayi = 0;
        private int Kasa = 0;
        Ordek o = new Ordek();
        İnek i = new İnek();
        Tavuk t = new Tavuk();
        Keci k = new Keci();
        UrunDeposu depo = new UrunDeposu();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void progressBar1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ProgressBarların değerlerini 100'e eşitliyorum.
            tavukcan.Value = 100;
            inekcan.Value = 100;
            ordekcan.Value = 100;
            kecican.Value = 100;      
            //kullanmış olduğum 9 timeri başlatıyorum.
            timer2.Start();

            tavukyumurta.Start();
            ordekyumurta.Start();
            ineksut.Start();
            kecisut.Start();

            tmrinekcan.Start();
            tmrtavukcan.Start();
            tmrordekcan.Start();
            tmrkecican.Start();
        }              
        private void lblsure_Click(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {  
            //Geçen süreyi hesaplıyorum.
            sayi += 1;
            lblsure.Text = Convert.ToString(sayi);            
        }

        private void lbltavukadet_Click(object sender, EventArgs e)
        {

        }

       
        private void ordekyumurta_Tick(object sender, EventArgs e)
        {
            //Keçi tavuk inek ve ördekte de aynı tarzda kod yazdım. Çalışma mantığı ise hayvanların timerlara
            //göre belirli zaman aralıklarında depodaki değişkeni arttırması ve form1deki labele yazdırması
            depo.OrdekYumurtasi++;
            lblordekadet.Text = Convert.ToString(depo.OrdekYumurtasi);
        }
        private void kecisut_Tick(object sender, EventArgs e)
        {
            depo.KeciSutu++;
            lblkeciadet.Text = Convert.ToString(depo.KeciSutu);
        }
        private void ineksut_Tick(object sender, EventArgs e)
        {
            depo.InekSutu++;
            lblinekadet.Text = Convert.ToString(depo.InekSutu); 
        }
        private void tavukyumurta_Tick(object sender, EventArgs e)
        {
            depo.TavukYumurtasi++;
            lbltavukadet.Text = Convert.ToString(depo.TavukYumurtasi);
        }
        private void btnineksat_Click(object sender, EventArgs e)
        {
            /*Bu kod parçam da diğer 3 hayvan için benzer nitelikte. İlk başta Gerektiği zaman çalışması için
             * Mesaj kutusu metodumu çağırdım. Daha sonrasında depoda bulunan hayvan ürününü belirtilen ürün 
             * değeri ile çarptım ve bunu kasa değişkenime aktardım. Daha sonra depodaki ürün adedimi 0ladım
             * son olarakta kasa değişkenimdeki değeri lblkasa'ya yazdırdım.*/
            i.MesajKutusu(lblinekadet);
            int İpara = depo.InekSutu;
            Kasa += İpara * 5;
            depo.InekSutu = 0;
            lblkasa.Text = Kasa.ToString();
            lblinekadet.Text = "0";
        }
        
        private void btntavuksat_Click(object sender, EventArgs e)
        {
            t.MesajKutusu(lbltavukadet);
            int Tpara = depo.TavukYumurtasi;
            Kasa += Tpara * 1;
            depo.TavukYumurtasi = 0;
            lblkasa.Text = Kasa.ToString();
            lbltavukadet.Text = "0";
            
        
        }
        private void btnkecisat_Click(object sender, EventArgs e)
        {
            k.MesajKutusu(lblkeciadet);
            int Kpara = depo.KeciSutu;
            Kasa += Kpara * 8;
            depo.KeciSutu = 0;
            lblkasa.Text = Kasa.ToString();
            lblkeciadet.Text = "0";
        }
        private void btnordeksat_Click(object sender, EventArgs e)
        {
            o.MesajKutusu(lblordekadet);
            int Opara = depo.OrdekYumurtasi;
            Kasa += Opara * 3;
            depo.OrdekYumurtasi = 0;
            lblkasa.Text = Kasa.ToString();
            lblordekadet.Text = "0";

        }

        private void btninekyem_Click(object sender, EventArgs e)
        {           
            //Hayvan classına yazmış olduğum yemver fonksiyonunu çağırıyorum.
            i.YemVer(inekcan);
        }
        private void btntavukyem_Click(object sender, EventArgs e)
        {
          
            t.YemVer(tavukcan);
        }

        private void btnordekyem_Click(object sender, EventArgs e)
        {
           
            o.YemVer(ordekcan);
        }

        private void btnkeciyem_Click(object sender, EventArgs e)
        {
          
            k.YemVer(kecican);
        }

        private void tmrinekcan_Tick(object sender, EventArgs e)
        {
            //Hayvanın Canı ile ilgili herşeyi barındıran metodumu çağırdım ve uygun parametreleri kullandım.
            i.Can(inekcan, tmrinekcan,ineksut, lblinekcanlimi);          
        }
        private void tmrtavukcan_Tick(object sender, EventArgs e)
        {
           
            t.Can(tavukcan,tmrtavukcan,tavukyumurta,lbltavukcanlimi);
        }

        private void tmrkecican_Tick(object sender, EventArgs e)
        {
         
            k.Can(kecican, tmrkecican,kecisut,lblkecicanlimi);
        }

        private void tmrordekcan_Tick(object sender, EventArgs e)
        {
            
            o.Can(ordekcan, tmrordekcan,ordekyumurta,lblordekcanlimi);
        }

        private void lblkeciadet_Click(object sender, EventArgs e)
        {

        }
    }
}
