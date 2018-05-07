using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A24.Wyjatki
{
    //3.
    //Konwencja używana w zdarzeniach parametr zdarzenia, nazwa jego typu zawsze się kończy się słowem EventArgs.
    //Nasza klasa dziedziczy z EventArgs - wszystkie zdarzenia dziedziczą z klasy EventArgs
    public class ZmienNazweEventArgs : EventArgs
    {
        public string IstniejacaNazwa { get; set; }
        public string NowaNazwa { get; set; }
    }
}
