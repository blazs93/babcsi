using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Ablakok
{

    //az étrend objektum egy étrend összes adatát tartalmazza minden egyes napra
    //minden ügyfélhez tartozik egy (egyetlen egy) ilyen objektum

    class Etrend
    {

        Ugyfel ugyfel;
        IUgyfelAdatkezelo adatkezelo;

        public Etrend(Ugyfel ugyfel)
        {
            this.ugyfel = ugyfel;
            adatkezelo = new Adatkezelo();
        }


        public void EtrendBetoltese()
        {
            adatkezelo.EtrendBetoltese(ugyfel);
        }

        void EtrendMentese()
        {
            adatkezelo.EtrendMentese(this);
        }

        public void EtelHozzaadas(DateTime nap, string etkezes, string etel, int mennyiseg)
        {

        }

        public void ErtekekKiszamolasa() //kaloria, zsir, stb
        {

        }
    }
}
