using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfApp_test_3P_piatek
{
    public class Pytanie
    {
        public string Tresc { get; set; }
        public bool Odpowiedz { get; set; }

        public Pytanie(string tresc, bool odpowiedz)
        {
            Tresc = tresc;
            Odpowiedz = odpowiedz;
        }
    }
}
