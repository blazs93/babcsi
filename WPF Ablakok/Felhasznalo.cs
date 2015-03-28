using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Ablakok
{

    //A felhasználó oszályok csak a leg alapabb adatokat tartalmazzák
    //főleg azonosítás céljából
    //majd a kezelő felületek foglalkoznak a többi adattal

    enum felhasznaloTipus { Ugyfel, Edzo, Alkalmazott, Tulajdonos }

    class Felhasznalo
    {
        public string ID { get; set; }
        public string Nev { get; set; }
        public felhasznaloTipus Tipus { get; private set; }
    }



    class Ugyfel : Felhasznalo
    {
        public Ugyfel()
        {

        }

        //egy felhasznalo alapjan megkeresi az adatbazisban az osszes adatot ami az ugyfelhez tartozik
        public Ugyfel(Felhasznalo felhasznalo)
        {

        }
    }



    class Edzo : Felhasznalo
    {
        public Edzo()
        {

        }

        public Edzo(Felhasznalo felhasznalo)
        {
        }
    }



    class Alkalmazott : Felhasznalo
    {
        public Alkalmazott()
        {

        }

        public Alkalmazott(Felhasznalo felhasznalo)
        {

        }
    }



    class Tulajdonos : Felhasznalo
    {
        public Tulajdonos()
        {

        }
    }
}
