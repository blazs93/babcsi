using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_Ablakok
{

    interface ITulajdonosKezeloFelulet
    {
        void EdzoTorlese(Edzo edzo);
        void UjEdzoFelvetele(string edzoNeve, string edzoLeirasa);
        void AlkalmazottTorlese(Alkalmazott alkalmazott);
        void UjAlkalmazottFelvetele(string alkalmazottNeve);
        void StatisztikaKeszites(Canvas canvas);
    }

    class TulajdonosKezeloFelulet:ITulajdonosKezeloFelulet
    {

        ITulajdonosAdatkezelo adatkezelo;

        public TulajdonosKezeloFelulet()
        {
            adatkezelo = new Adatkezelo();
        }



        public void EdzoTorlese(Edzo edzo)
        {
            adatkezelo.EdzoTorlese(edzo);
        }

        public void UjEdzoFelvetele(string edzoNeve, string edzoLeirasa)
        {
            Edzo ujEdzo = new Edzo();
            //edző adatainak beállítása
            adatkezelo.UjEdzoFelvetele(ujEdzo);
        }

        public void AlkalmazottTorlese(Alkalmazott alkalmazott)
        {
            adatkezelo.AlkalmazottTorlese(alkalmazott);
        }

        public void UjAlkalmazottFelvetele(string alkalmazottNeve)
        {
            Alkalmazott ujAlkalmazott = new Alkalmazott();
            ujAlkalmazott.Nev = alkalmazottNeve; //a többi adat beállítása is majd
            adatkezelo.UjAlkalmazottFelvetele(ujAlkalmazott);
        }

        public void StatisztikaKeszites(Canvas canvas)
        {
            List<int> eladasiAdatok = adatkezelo.EladasiStatisztikaiAdatokLekerese();
            //majd az adatok alapján a paraméterül kapott canvasra lerajzolja a statisztikákat amit
            //az adatkezeéőtől kapott
        }
    }
}
