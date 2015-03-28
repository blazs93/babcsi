using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Ablakok
{

    //Az alkalmazott kezelő ablak ezen az interfészen keresztül éri el az osztály függvényeit
    interface IAlkalmazottKezeloFelulet
    {
        bool BerletEllenorzes(string berletAzonosito);
        void JegyEladas(int darab);
        void UjUgyfelFelveteleBerleteladassal(int napokSzama);
        void BerletEladas(int napokSzama, Ugyfel ugyfel);
    }

    class AlkalmazottKezeloFelulet:IAlkalmazottKezeloFelulet
    {

        Alkalmazott bejelentkezettAlkalmazott;
        IAlkalmazottAdatkezelo adatkezelo;

        public AlkalmazottKezeloFelulet(Alkalmazott alkalmazott)
        {
            bejelentkezettAlkalmazott = alkalmazott;
            adatkezelo = new Adatkezelo();
        }



        public bool BerletEllenorzes(string berletAzonosito)
        {
            DateTime lejaratiDatum = new DateTime();
            return adatkezelo.BerletEllenorzes(berletAzonosito, ref lejaratiDatum);
        }



        public void JegyEladas(int darab)
        {
            adatkezelo.JegyEladasLoggolasa(darab);
        }


        //majd az ablaktól megkapja paraméterként az ügyfél adatait 
        //az adatok alapján létrehozza a felhasználot
        public void UjUgyfelFelveteleBerleteladassal(int napokSzama)
        {
            Ugyfel ujUgyfel = new Ugyfel();
            //ujUgyfel feltöltés adatokkal 
            adatkezelo.UjUgyfelFelvetele(ujUgyfel);
            BerletEladas(napokSzama, ujUgyfel);
        }



        public void BerletEladas(int napokSzama, Ugyfel ugyfel)
        {
            adatkezelo.BerletEladasLoggolasa(ugyfel, napokSzama);
        }
    }
}
