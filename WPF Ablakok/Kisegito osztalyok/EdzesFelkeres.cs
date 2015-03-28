using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Ablakok
{
    class EdzesFelkeres
    {
        //a felkérés adatai, ezek fognak szerepelni az edző kezelő ablakán
        //az edzések elfogadása fül alatti listában

        Ugyfel ugyfel;
        DateTime idopont;
        string megjegyzes;

        public EdzesFelkeres(Ugyfel ugyfel, DateTime idopont)
        {
            this.ugyfel = ugyfel;
            this.idopont = idopont;
        }

        public void MegejegyzesHozzaadasa(string megjegyzes)
        {
            this.megjegyzes += megjegyzes;
        }
        
    }
}
