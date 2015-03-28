using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Ablakok
{

    interface IEdzoKezeloFelulet
    {
        void OrarendMegjelenites();
        void EdzesElfogadasa(EdzesFelkeres edzesFelkeres);
        void EdzesElutasitasa(EdzesFelkeres edzesFelkeres);
        void BemutatkozoSzerkesztese(string ujBemutatkozo);
    }

    class EdzoKezeloFelulet:IEdzoKezeloFelulet
    {

        Edzo bejelentkezettEdzo;
        IEdzoAdatkezelo adatkezelo;
        Orarend orarend;

        public EdzoKezeloFelulet(Edzo edzo)
        {
            bejelentkezettEdzo = edzo;
            adatkezelo = new Adatkezelo();
        }

        public void OrarendMegjelenites()
        {
            orarend = new Orarend(bejelentkezettEdzo);
            orarend.Kirajzol();
        }

        public void EdzesElfogadasa(EdzesFelkeres edzesFelkeres)
        {
            adatkezelo.EdzesElfogadasa(edzesFelkeres);
        }

        public void EdzesElutasitasa(EdzesFelkeres edzesFelkeres)
        {
            adatkezelo.EdzesElutasitasa(edzesFelkeres);
        }

        public void BemutatkozoSzerkesztese(string ujBemutatkozo)
        {
            adatkezelo.BemutatkozoSzerkesztese(bejelentkezettEdzo, ujBemutatkozo);
        }
    }
}
