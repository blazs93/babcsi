using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Ablakok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();


            //UgyfelWindow a = new UgyfelWindow();
            //a.Show();
            //EdzoWindow b = new EdzoWindow();
            //b.Show();
            //AlkalmazottWindow c = new AlkalmazottWindow();
            //c.Show();
            //TulajdonosWindow d = new TulajdonosWindow();
            //d.Show();
            //////

        }


        //Ha megnyomták a bejelentkezés gombot
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //linq-val megkeressük, hogy létezik-e ilyen felhasználó
            //és ha létezik akkor eldöntjül, hogy milyen típusu (edző, ügyfél, stb)
            //ennek megfelelően megnyitunk egy ablakot, ezt bezárjuk

            Felhasznalo felhasznalo = new Felhasznalo();

            switch (felhasznalo.Tipus)
            {
                case (felhasznaloTipus.Ugyfel):
                    UgyfelWindow ugyfelWindow = new UgyfelWindow();
                    ugyfelWindow.DataContext = felhasznalo;
                    ugyfelWindow.Show();
                    this.Close();
                    break;

                case (felhasznaloTipus.Edzo):
                    break;

                case (felhasznaloTipus.Alkalmazott):
                    break;

                case (felhasznaloTipus.Tulajdonos):
                    break;
            }

        }



    }
}
