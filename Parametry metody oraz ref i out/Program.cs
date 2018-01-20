using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametry_metody_oraz_ref_i_out
{
    class Program
    {
        //Parametry metody oraz ref i out


        static void DajNazwe(Dzienniczek dzienniczek)
        {
            dzienniczek.Nazwa = "Dzienniczek Marcina";
        }

        static void InkrementacjaLiczba(int liczba)
        {
            //W tym przypadku to zwiększenie bedzie tylko działało w tej metodzie. Ponieważ metoda wywoływana jest przez wartość a nie referencje czyli wskaźnik do obiektu.
            liczba += 42;
        }

        // ref - nie chcę już przekazywać parametru przez wartość ale chcę przekazywać przez referencję(wskaźnik).
        static void DajNazweRef(ref Dzienniczek dzienniczek)
        {
            //Jeżeli przypisuje nowy dzienniczek to to samo zostanie przypisane do zmiennej dzienniczek4.
            dzienniczek = new Dzienniczek();
            dzienniczek.Nazwa = "Nowy Dzienniczek Marcina";
        }

        static void DajNowaNazwe(Dzienniczek dzienniczek)
        {
            //Zmienna dzienniczek wskazuje na nowy obiekt i dlatego nazwa po ustawieniu dzienniczek3 lub dzienniczek4 nie zostanie wyświetlona i tak samo jest w metodzie InkrementacjaLiczba inkrementacja działa tylko w metodzie.
            dzienniczek = new Dzienniczek();
            dzienniczek.Nazwa = "Nowy Dzienniczek Marcina";
        }

        static void InkrementacjaLiczbaRef( ref int liczba)
        {
            //W tym przypadku to zwiększenie bedzie tylko działało w tej metodzie. Ponieważ metoda wywoływana jest przez wartość a nie referencje czyli wskaźnik do obiektu.
            liczba += 42;
        }
     
        static void InkrementacjaLiczbaOut( out int liczba)
        {

            //W tym przypadku to zwiększenie bedzie tylko działało w tej metodzie. Ponieważ metoda wywoływana jest przez wartość a nie referencje czyli wskaźnik do obiektu.
            liczba = 42;
        }

        // Przypisanie metody zwracającej wartość bez
        static int InkrementacjaLiczbaWatosciowametoda ( int liczba)
        {    
            liczba = 42;
            return liczba;

        }

        static void Main(string[] args)
        {
           

            // Zmienna dzienniczek1 wskazuje na obiekt  Dzienniczek();
            Dzienniczek dzienniczek1 = new Dzienniczek();
            //obie zmienne wskazuja na ten sam obiekt
            Dzienniczek dzienniczek2 = dzienniczek1;

            DajNazwe(dzienniczek1);

            //Kiedy wywołujemy metodę zawwsze przekazujemy wartość.
            // Zmienne dzienniczek dzienniczek1 dzienniczek2 wskazują na te sam obiekt.
            Console.WriteLine(dzienniczek2.Nazwa);
            Console.WriteLine(dzienniczek1.Nazwa);


          

            int x1 = 4;
            InkrementacjaLiczba(x1);
            //Kiedy wywołujemy metodę InkrementacjaLiczba wciąż przekazujmy przez wartość co oznacza że przyjmujemy liczbę x1 = 4 i kopiujemy ją do zmiennej liczba w metodzie InkrementacjaLiczba.
            Console.WriteLine(x1);

            Dzienniczek dzienniczek3 = new Dzienniczek();
            //obie zmienne wskazuja na ten sam obiekt
            Dzienniczek dzienniczek4 = dzienniczek3;
            DajNowaNazwe(dzienniczek4);
            Console.WriteLine("Tutaj nie będzie nazwy" + dzienniczek4.Nazwa);


            // ref i out - to dwa słowa kluczowe które zmieniają zachowanie parametrów w metodzie.
            // Należy używać ich oszczędnie.

            //ref - przyjmuje że metoda została już zainicjonowana jakąś wartością zanim została wywołana.

            //parametr przekazany przez referencję- nie kopiujemy wartości.
            DajNazweRef(ref dzienniczek4);
            Console.WriteLine(dzienniczek4.Nazwa);

            //ref - parametr przekazany przez referencję- nie kopiujemy wartości.
            int x2 = 4;
            InkrementacjaLiczbaRef(ref x2);
            Console.WriteLine(x2);

            //out
            int x3 = 4;        
            InkrementacjaLiczbaOut(out x3);
            Console.WriteLine(x3);

            //Róznica między słowkiem ref a out - przy ref zmienna musi być zainicjalizowna wczesniej natomiast przy out zmienną zainicjalizowna jest wewn. metody lub poprzez przypisanie niezainicjalizwanej metody.


            int x5 = 48;
            x5 = InkrementacjaLiczbaWatosciowametoda(x5);
            // Mamy pewność że liczba przypisana z metody bedzie miała tą samą wartość.
            Console.WriteLine(x5);
        }
    }
}
