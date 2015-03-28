using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Ablakok.Kezelo_feluletek
{

    interface IUgyfelKezeloFelulet
    {
        void OrarendMegjelenites();
        void FejlodesAdatokBetoltese();
        void EdzoErtekelese(Edzo edzo, int ertekeles);
        void JelszoValtoztatas(string regiJelszo, string ujJelszo);
        void AdatokModositasa(string email, string telefon);
    }


    class UgyfelKezeloFelulet : IUgyfelKezeloFelulet
    {

        IUgyfelAdatkezelo adatkezelo;
        Ugyfel bejelentkezeteUgyfel;
        Edzesterv edzesterv;
        Etrend etrend;
        Orarend orarend;

        public UgyfelKezeloFelulet(Ugyfel ugyfel)
        {
            bejelentkezeteUgyfel = ugyfel;
            adatkezelo = new Adatkezelo();

            edzesterv = new Edzesterv(bejelentkezeteUgyfel);
            edzesterv.EdzestervBetoltese();

            etrend = new Etrend(bejelentkezeteUgyfel);
            etrend.EtrendBetoltese();
        }

        public void OrarendMegjelenites()
        {
            orarend = new Orarend(bejelentkezeteUgyfel);
            orarend.Kirajzol();
        }

        public void FejlodesAdatokBetoltese()
        {
            adatkezelo.FejlodesAdatokBetoltese(bejelentkezeteUgyfel);
        }

        public void EdzoErtekelese(Edzo edzo, int ertekeles)
        {
            adatkezelo.EdzoErtekelese(bejelentkezeteUgyfel, edzo, ertekeles);
        }

        public void JelszoValtoztatas(string regiJelszo, string ujJelszo)
        {
            adatkezelo.JelszoValtoztatas(bejelentkezeteUgyfel, ujJelszo);
        }

        public void AdatokModositasa(string email, string telefon)
        {
            adatkezelo.AdatokModositasa(bejelentkezeteUgyfel, email, telefon);
        }
    }
}
