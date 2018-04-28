using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A23.Throw.Wyjatki
{
    //Poniższy delegat pobiera dwa parametry i nic nie zwraca, zwraca void.
    //Uwaga: Poniższe nazwy parametrów są arbitralne to znaczy że kompilator c# kiedy sprawdza właściwą metodę nie sprawdza nazw parametrów a jedynie sprawdza typy która metoda pobiera i typ który zwraca!!! (jakie typy przychodzą do delegata i co zwraca).
    //1.
    public delegate void NazwaSieZmieniaDelegate(string nazwaJuzIstniejaca, string nowaNazwa);
}
