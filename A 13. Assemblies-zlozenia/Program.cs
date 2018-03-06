using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace A_13.Assemblies_zlozenia
{
    class Program
    {


        static void Main(string[] args)
        {


            //Assemblies - zlozenia to odwołania do typów które mamy przygotowane przez np. Microsoft.
            //References jest zbiorem zestawów które używamy.
            //klikając prawym klawiszem myszy na wybranej referencji możemy przejść do Object Browser w którym możemy przeglądać przestrzenie nazw a w nich wiele róznych typów związanych z daną przestrzenią nazw - do wykorzystania w nazym projekcie.
            //mscorlib - dodawany zawsze w projekcie ze względu na postaową funkcjonalność - typy prymitywne np int32.
            // Add Referencres umożliwia dodawanie wielu nowych złożeń Assemblies.
            //Dzienniczek dzienniczek = new Dzienniczek();

            //dzienniczek.DodajOcene(5);
            //dzienniczek.DodajOcene(8.5f);
            //dzienniczek.DodajOcene(4.7f);
            //dzienniczek.DodajOcene(2.7f);


            //Wszystkie statystyki obliczone są przechowywane w obiekcie statystyki dzienniczka. 
            // + dodajemy nasze wartości do stringa

            //StatystykiDzienniczka statystyki = dzienniczek.CompletneStatystyki();

            //Console.WriteLine("Średnia ocena " + statystyki.sredniaOcena);
            //Console.WriteLine("Maksymalna ocena " + statystyki.maxOcena);
            //Console.WriteLine("Minimalna ocena " + statystyki.minimalnaOcena);

            // Dzienniczek 2
            //Dzienniczek dzienniczek2 = new Dzienniczek();

            //dzienniczek2.DodajOcene(5);
            //dzienniczek2.DodajOcene(3.5f);
            //dzienniczek2.DodajOcene(8.7f);
            //dzienniczek2.DodajOcene(5.7f);

            //Wstawiamy nowe wartosci z dzienniczka 2
            //statystyki = dzienniczek2.CompletneStatystyki();

            //Console.WriteLine("Średnia ocena " + statystyki.sredniaOcena);
            //Console.WriteLine("Maksymalna ocena " + statystyki.maxOcena);
            //Console.WriteLine("Minimalna ocena " + statystyki.minimalnaOcena);


            //Użycie złożenia Speech.Synthesis.
            SpeechSynthesizer synt = new SpeechSynthesizer();
            synt.Speak("Cześć Marcin etap dodania do projektu Speech.Synthesis został zakończony");

            Console.ReadKey();
            //Static

            //aby nie było błedu przypisujemy do zmiennej
            //var zmienna = Dzienniczek.MaksymalnaOcena;
            //WriteLine(); - To też metoda statyczna nie musimy tworzyć stancji obiektu.
            //Console.WriteLine(Dzienniczek.MaksymalnaOcena);
            // Console.- wszystko po kropce pola i metody to są statiki

            //Dzienniczek dzienniczek3 = new Dzienniczek();
            //Dzienniczek dzienniczek4 = new Dzienniczek();
            //Dzienniczek dzienniczek5 = new Dzienniczek();
            //Dzienniczek dzienniczek6 = new Dzienniczek();
            //Statick dostępne na poziomie klasy.
            //Console.WriteLine(Dzienniczek.Licznik);
            // Dostępne na poziomie obiektu
            //Console.WriteLine(dzienniczek5.Licznik2);
            //Console.WriteLine(dzienniczek6.Licznik2);
        }
    }
}
