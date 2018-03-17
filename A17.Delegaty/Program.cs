using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17.Delegaty
{
    class Program
    {
        //Delegaty
        //Potrzebujemy zmiennej która odwołuje się do metody.
        //Delegat jest typem który odwołuje się do metod.
        //Delegat jak jest zadeklarowany określa jakie metody mogą do niego być podpięte.
        // Delegat pozwala nam mieć zmienną która wskazuje na metode a ponieważ to jest zmienna może wskazywać na inną metodę którą można przypisać. 
        //Przykład
        //public delegate void Wczytaj(string wiadomosc);

        //public class Logger
        //{
        //    public void WczytajWiadomosc(string wiadomosc)
        //    {
        //        Console.WriteLine(wiadomosc);
        //    }          
        //}

        //Logger logger = new Logger();
        //Wczytaj wczytaj = new Wczytaj(logger.WczytajWiadomosc);
        //wczytaj("Witam!!");

        static void Main(string[] args)
        {
            Dzienniczek dzienniczek = new Dzienniczek();

            //4.
            //Tworzymy delegat i przypisujemy mu funkcję która ma być wykonana.
            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono);
            //aby metody nie nadpisywały się i nie otzymywalismy samych gwiazdek dodajemy +=
            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono2);
            //Wywoływane są wszystkie metody które są podpięte pod ten delegat.
            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono3);

            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono4);
            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono4);
            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono4);

            dzienniczek.Nazwa = "Dzienniczek Marcina";
            dzienniczek.Nazwa = "Przemek Hej";
            Console.WriteLine(dzienniczek.Nazwa);
        }
        //5.
        //Ta Metoda zgadza się z sygnaturą naszego delegata ponieważ pobiera dwa stringi i zwraca void
        private static void NazweZmieniono(string nazwaJuzIstniejaca, string nowaNazwa)
        {
            //Zmiana nazwy z puste na dzienniczek Marcina - delegat się wykonał
            //Następnie Zmiana nazwy z Dzienniczek Marcina na Przemek Hej - delegat się wykonał kolejny raz.
            Console.WriteLine($"Zmiana nazwy z {nazwaJuzIstniejaca} na {nowaNazwa}");
        }

        private static void NazweZmieniono2(string nazwaJuzIstniejaca, string nowaNazwa)
        {
           
            Console.WriteLine("*******************");
        }

        private static void NazweZmieniono3(string nazwaJuzIstniejaca, string nowaNazwa)
        {
            
            Console.WriteLine("Cześć");
        }

        private static void NazweZmieniono4(string nazwaJuzIstniejaca, string nowaNazwa)
        {

            Console.WriteLine("++++++++++++++++++");
        }
    }
}
