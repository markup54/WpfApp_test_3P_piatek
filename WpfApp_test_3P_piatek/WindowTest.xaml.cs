using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace WpfApp_test_3P_piatek
{
    /// <summary>
    /// Logika interakcji dla klasy WindowTest.xaml
    /// </summary>
    public partial class WindowTest : Window
    {
        List<Pytanie> listaPytan { get; set; }
        public WindowTest()
        {
            InitializeComponent();
            przygotuPytania();
            wyswietlPytanie(0);
        }

        private void wyswietlPytanie(int i)
        {
            tresc_pytania_textblock.Text = listaPytan[i].Tresc;
        }

        private void przygotuPytania()
        {
            listaPytan = new List<Pytanie>();
            StreamReader streamReader = new StreamReader("pytania.txt");
            string tresc = streamReader.ReadLine();
            string odp= streamReader.ReadLine();
            while (tresc != null)
            {
                if(odp=="tak")
                listaPytan.Add(new Pytanie(tresc, true));
                else
                    listaPytan.Add(new Pytanie(tresc, false));
                tresc = streamReader.ReadLine();
                odp = streamReader.ReadLine();
            }
            streamReader.Close();
        }
    }
}
