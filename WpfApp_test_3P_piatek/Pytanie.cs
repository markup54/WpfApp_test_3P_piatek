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
        public Pytanie(string tresc, string odpowiedz)
        {
            Tresc = tresc;
            if(odpowiedz == "tak")
            Odpowiedz = true;
            else Odpowiedz = false;
        }
    }
    public class Pytanie2
    {
        public string Tresc { get; set; }
        public string Odpowiedz { get; set; }
        public Pytanie2(string tresc, string odpowiedz)
        {
            Tresc = tresc;

            Odpowiedz = odpowiedz;

        }
        
    }
}
