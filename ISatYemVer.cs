using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proje_ödevim
{
    interface ISatYemVer
    {
        //Hayvan Classında ve 4 hayvan classında kullanacağım metodların temelini atıyorum.
        void YemVer(ProgressBar Can);
        void Can(ProgressBar Can, Timer timer, Timer timer2, Label can);
    }
}
