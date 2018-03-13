using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A16.Pola_i_Wlasciwosci
{
    class Program
    {
        // Pola definiują zmienne wewnątrz klasy, struktury - definiują stan lub dane które chcemy zachować jako część  obiektu. Pola zazwyczaj są prywatne - chcemy chronić dane.
        // Właściwośc jest podobna do pola ponieważ kontroluje stan i dane powiązane z obiektem. Właściwości używają akcesorów get i set dzięki którym uzyskujemy dostęp do pól poza klasą. Akcesory mogą zawierać kod które działają podobnie jak metody i można w nich robić obliczenia, sprawdzanie poprawności. Mogę napisać dowolną ilość w akcesorze ale musze zwrócić return. w secie możemy postawić warunki kiedy to pole jest zapisane natomiast w get możemy napisać logikę.
        static void Main(string[] args)
        {
            //Metody definują zachowanie.
            //Metody - domyslnie private, public, internal - w obrębie projektu.
            //Metody maja typ zwracany - np void bez returna lub return
            //metoda może przyjmować wiele parametrów
            // nawiasy klamrowe formatują ciagi znaków np ("0x{0:x2} ", b) - zapis liczby szesnastkowej.

            //params - używane do przekazywania zmiennej liczby parametrów do metody, zawsze dodajemy do ostatniego parametru ponieważ możemy przekazać dowolną ilość parametrów np tablicę float.

            //sygnatura metody - podpis metody identyfikujacy metode - nazwa i lista parametrow przekazywanych do metody.

            Dzienniczek dzienniczek = new Dzienniczek();

            dzienniczek.DodajOcene(5);
            dzienniczek.DodajOcene(8.5f);
            dzienniczek.DodajOcene(4.7f);
            dzienniczek.DodajOcene(2.7f);

            StatystykiDzienniczka statystyki = dzienniczek.CompletneStatystyki();

            //metody zostały zrzutowane
            //Możemy zaznaczyć linie i uruchomic kod do danej linii -  Run To Cursor  
            //WczytajWynik("Średnia", statystyki.sredniaOcena, 3, 5, 7, 8, 9);
            //WczytajWynik("Max", (int)statystyki.maxOcena);
            //WczytajWynik("Min", (long)statystyki.minimalnaOcena);
            //WczytajWynik("Min", (long)statystyki.minimalnaOcena, 1);
            //WczytajWynik("Min", statystyki.minimalnaOcena, 1);
            //WczytajWynik("Min", (int)statystyki.minimalnaOcena, 1);

            dzienniczek.Nazwa = "Dzienniczek Marcina";
            dzienniczek.Nazwa = "";
            dzienniczek.Nazwa = null;
            Console.WriteLine(dzienniczek.Nazwa); 
        }

        //musi być to metoda statyczna - u góry tez jest static
        static void WczytajWynik(string opis, params float[] wynik)
        {
            Console.WriteLine(opis + ": " + wynik[0] + "   " + wynik[4]);
        }
        // Przeciazenie metod - overloadig
        static void WczytajWynik(string opis, int wynik)
        {
            Console.WriteLine(opis + ": " + wynik);
        }
        // Przeciazenie metod
        static void WczytajWynik(string opis, long wynik)
        {
            Console.WriteLine(opis + ": " + wynik);
        }
        // Przeciazenie metod
        static void WczytajWynik(string opis, long wynik, long test)
        {
            Console.WriteLine(opis + ": " + wynik);
        }
        //używamy placeholdera {}
        // rózne formatowania.
        static void WczytajWynik(string opis, float wynik, long tests)
        {
            Console.WriteLine("{0}: {1:F2}: {2:C1}: {3}: {4}: {5}:", opis, wynik, 2, 3, 4, 5);
        }
        // zapis z c# 6.0
        static void WczytajWynik(string opis, int wynik, long tests)
        {
            Console.WriteLine($"{opis}: {wynik:F3}: {2:C1}: {3}: {4}: {5}: ");
        }
    }    
}
