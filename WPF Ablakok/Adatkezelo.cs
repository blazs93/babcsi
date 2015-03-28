using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Ablakok
{

    //ezen az interfészen keresztül éri el az alkalmazott az adatbázist
    interface IAlkalmazottAdatkezelo
    {
        bool BerletEllenorzes(string berletAzonosito, ref DateTime ervenyessegIdeje);
        void JegyEladasLoggolasa(int darab);
        void UjUgyfelFelvetele(Ugyfel ujUgyfel);
        void BerletEladasLoggolasa(Ugyfel ugyfel, int napokSzama);
    }

    interface ITulajdonosAdatkezelo
    {
        void EdzoTorlese(Edzo edzo);
        void UjEdzoFelvetele(Edzo edzo);
        void AlkalmazottTorlese(Alkalmazott alkalmazott);
        void UjAlkalmazottFelvetele(Alkalmazott alkalmazott);
        List<int> EladasiStatisztikaiAdatokLekerese();
    }

    interface IUgyfelAdatkezelo
    {
        void EdzestervBetoltese(Ugyfel ugyfel);
        void EdzestervMentese(Edzesterv edzesterv);
        void EloreElkeszitettEdzestervBetoltese(string valasztottEdzesterv);
        void EtrendBetoltese(Ugyfel ugyfel);
        void EtrendMentese(Etrend etrend);
        void FejlodesAdatokBetoltese(Ugyfel ugyfel);
        void EdzoErtekelese(Ugyfel ugyfel, Edzo edzo, int ertekeles);
        void JelszoValtoztatas(Ugyfel ugyfel, string ujJelszo);
        void AdatokModositasa(Ugyfel ugyfel, string email, string telefon);
        void UgyfelOrarendBetoltese(Ugyfel ugyfel);
    }

    interface IEdzoAdatkezelo
    {
        void EdzoOrarendBetoltese(Edzo edzo);
        void EdzesElfogadasa(EdzesFelkeres edzesFelkeres);
        void EdzesElutasitasa(EdzesFelkeres edzesFelkeres);
        void BemutatkozoSzerkesztese(Edzo edzo, string ujBemutatkozo);
    }


    class Adatkezelo: IAlkalmazottAdatkezelo, ITulajdonosAdatkezelo, IEdzoAdatkezelo, IUgyfelAdatkezelo
    {

        //majd ez az osztály fogja elvégezni az adatok betöltését linq-val
        //ez az osztály fog elvégezni minden adatbázissal való érintkezést 

        public Adatkezelo()
        {

        }


        //Ezek csak elmentik az adatokat az adatbázisba!
        public bool BerletEllenorzes(string berletAzonosito, ref DateTime ervenyessegIdeje)
        {
            throw new NotImplementedException();
        }

        public void JegyEladasLoggolasa(int darab)
        {
            throw new NotImplementedException();
        }

        public void UjUgyfelFelvetele(Ugyfel ujUgyfel)
        {
            throw new NotImplementedException();
        }

        public void BerletEladasLoggolasa(Ugyfel ugyfel, int napokSzama)
        {
            throw new NotImplementedException();
        }

        public void EdzoTorlese(Edzo edzo)
        {
            throw new NotImplementedException();
        }

        public void UjEdzoFelvetele(Edzo edzo)
        {
            throw new NotImplementedException();
        }

        public void AlkalmazottTorlese(Alkalmazott alkalmazott)
        {
            throw new NotImplementedException();
        }

        public void UjAlkalmazottFelvetele(Alkalmazott alkalmazott)
        {
            throw new NotImplementedException();
        }

        public List<int> EladasiStatisztikaiAdatokLekerese()
        {
            throw new NotImplementedException();
        }

        public void EdzoOrarendBetoltese(Edzo edzo)
        {
            throw new NotImplementedException();
        }

        public void EdzesElfogadasa(EdzesFelkeres edzesFelkeres)
        {
            throw new NotImplementedException();
        }

        public void EdzesElutasitasa(EdzesFelkeres edzesFelkeres)
        {
            throw new NotImplementedException();
        }

        public void BemutatkozoSzerkesztese(Edzo edzo, string ujBemutatkozo)
        {
            throw new NotImplementedException();
        }



        public void EdzestervBetoltese(Ugyfel ugyfel)
        {
            throw new NotImplementedException();
        }

        public void EdzestervMentese(Edzesterv edzesterv)
        {
            throw new NotImplementedException();
        }

        public void EloreElkeszitettEdzestervBetoltese(string valasztottEdzesterv)
        {
            throw new NotImplementedException();
        }

        public void EtrendBetoltese(Ugyfel ugyfel)
        {
            throw new NotImplementedException();
        }

        public void EtrendMentese(Etrend etrend)
        {
            throw new NotImplementedException();
        }

        public void FejlodesAdatokBetoltese(Ugyfel ugyfel)
        {
            throw new NotImplementedException();
        }

        public void EdzoErtekelese(Ugyfel ugyfel, Edzo edzo, int ertekeles)
        {
            throw new NotImplementedException();
        }

        public void JelszoValtoztatas(Ugyfel ugyfel, string ujJelszo)
        {
            throw new NotImplementedException();
        }

        public void AdatokModositasa(Ugyfel ugyfel, string email, string telefon)
        {
            throw new NotImplementedException();
        }


        public void UgyfelOrarendBetoltese(Ugyfel ugyfel)
        {
            throw new NotImplementedException();
        }
    }
}
