using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Typy_Referencyjne_i_Wrtościowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Komentowanie kodu control + K + C

            //            Dzienniczek dzienniczek = new Dzienniczek();

            //            dzienniczek.DodajOcene(5);
            //            dzienniczek.DodajOcene(8.5f);
            //            dzienniczek.DodajOcene(4.7f);
            //            dzienniczek.DodajOcene(2.7f);

            //            Dzienniczek dzienniczek3 = new Dzienniczek();
            //            Dzienniczek dzienniczek4 = new Dzienniczek();
            //            Dzienniczek dzienniczek5 = new Dzienniczek();
            //            Dzienniczek dzienniczek6 = new Dzienniczek();

            //            Wszystkie statystyki obliczone są przechowywane w obiekcie statystyki dzienniczka.
            //             + dodajemy nasze wartości do
            //                stringa

            //StatystykiDzienniczka statystyki = dzienniczek.CompletneStatystyki();

            //Typ referencyjny - zmienna zawiera referencje czyli odniesienie inaczej wskaźnik do obiektu.

            // Zmienna dzienniczek1 wskazuje na obiekt  Dzienniczek();
            Dzienniczek dzienniczek1 = new Dzienniczek();
            //obie zmienne wskazuja na ten sam obiekt
            Dzienniczek dzienniczek2 = dzienniczek1;

            //zmienna dzienniczek1 wskazuje na nowy obiekt - po odkomentowaniu nie będzie działać Dzienniczek Marcina.
            //dzienniczek1 = new Dzienniczek();
            dzienniczek1.Nazwa = "Dzienniczek Marcina";
            //dzienniczek1 oraz dzienniczek2 wskazują na ten sam obiekt.
            Console.WriteLine(dzienniczek2.Nazwa);

            // Typy wartościowe.
            // Każda zmienna wartościowa jest niezależna od siebie.

            int x1 = 4;
            //Przy typach wartoscowych tworzona jest kopia zmiennej wartościowej - zmienna przechowuje wartość która jest niezależna.
            //Przy typach referencyjnych zmienne wskazują na ten sam obiekt.
            int x2 = x1;
            //jeżeli zmienimy x1 na 100 to x2 zostaje nadal 4
            x1 = 100;

            // W typie wartościowym x2 będzięmy mieli 4
            Console.WriteLine(x2);
            // W typie wartościowym x1 będzięmy mieli 100
            Console.WriteLine(x1);
            // Natomiast typy referencyjne wskazują na ten sam obiekt.
        }
    }
}
