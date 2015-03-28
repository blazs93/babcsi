using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Ablakok
{
    class Edzesterv
    {

        //az edzésterv objektum egy edzés összes adatát tartalmazza minden egyes napra
        //minden ügyfélhez tartozik egy (egyetlen egy) ilyen objektum
        //ez lehet egy előre elkészített (amit ki lehet választani) edzésterv
        //vagy amit az ügyfél állított össze

        Ugyfel ugyfel;
        IUgyfelAdatkezelo adatkezelo;

        public Edzesterv(Ugyfel ugyfel)
        {
            this.ugyfel = ugyfel;
            adatkezelo = new Adatkezelo();
        }


        public void EdzestervBetoltese()
        {
            adatkezelo.EdzestervBetoltese(ugyfel);
        }


        void EdzestervMentese()
        {
            adatkezelo.EdzestervMentese(this);
        }

        

        void GyakorlatHozzaadasaKivalasztottNaphoz(DateTime nap, string gyakorlat, int szeriaSzam, int ismetlesekSzama)
        {

        }


        void EloreElkeszitettEdzestervBetoltese(string valasztottEdzesterv)
        {
            adatkezelo.EloreElkeszitettEdzestervBetoltese(valasztottEdzesterv);
        }
    }
}
