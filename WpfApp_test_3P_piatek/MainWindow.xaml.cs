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

namespace WpfApp_test_3P_piatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Test_Click(object sender, RoutedEventArgs e)
        {
            Window okno = new WindowTestJason();
            okno.ShowDialog();
        }

        private void Button_Dodaj_Click(object sender, RoutedEventArgs e)
        {
            Window okno = new WindowDodajPytanie();
            //okno.Show();//okno niemodalne
            okno.ShowDialog();//okno modalne
        }
    }
}
