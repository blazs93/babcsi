using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Ablakok
{
    class Orarend
    {

        public Orarend(Ugyfel ugyfel)
        {
            UgyfelAdatokBetoltese(ugyfel);
        }



        void UgyfelAdatokBetoltese(Ugyfel ugyfel)
        {
            IUgyfelAdatkezelo adatkezelo = new Adatkezelo();
            adatkezelo.UgyfelOrarendBetoltese(ugyfel);
        }



        public Orarend(Edzo edzo)
        {
            EdzoAdatokBetoltese(edzo);
        }



        void EdzoAdatokBetoltese(Edzo edzo)
        {
            IEdzoAdatkezelo adatkezelo = new Adatkezelo();
            adatkezelo.EdzoOrarendBetoltese(edzo);
        }



        public void Kirajzol()
        {

        }



        public void Modosit()
        {

        }



        public void ModositasokMentese()
        {
        }




    }
}
