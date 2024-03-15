using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
    /// Logika interakcji dla klasy WindowTestJason.xaml
    /// </summary>
    public partial class WindowTestJason : Window
    {
        public List<Pytanie2> listaPytan { get; set; }
        public WindowTestJason()
        {
            InitializeComponent();
            odczytajPytania();
            tresc_pytania_textblock.Text = listaPytan[0].Tresc;
        }
        private void odczytajPytania()
        {
            //listaPytan = new List<Pytanie>();
            StreamReader streamReader = new StreamReader("../../../pytaniaJson.txt");
            string pytaniaJason = streamReader.ReadToEnd();
            streamReader.Close();
            using FileStream openStream = File.OpenRead("../../../pytaniaJson.txt");

            listaPytan = JsonSerializer.Deserialize<List<Pytanie2>>(openStream);
               
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
/*
 * string fileName = "WeatherForecast.json";
            using FileStream openStream = File.OpenRead(fileName);
            WeatherForecast? weatherForecast = 
                await JsonSerializer.DeserializeAsync<WeatherForecast>(openStream);

 */