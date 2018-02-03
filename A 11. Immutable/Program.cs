using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_11.Immutable
{
    class Program
    {
        //Immutable - typy wartościowe są niezmienne.
        // Po utworzeniu typu wartościowego nie możemy zmienić wartości - dopiero w zmiennej.
        // wartość zmiennej może się zmienić.
        // Typ string jest typem referncyjnym - łańcuch jest typem referencyjnym ale zachowuje się jak typ wartościowy.
        //Trim usuwa początkowe i końcowe znaki białe - np "  Marcin  ";


        static void DajNazwe(Dzienniczek dzienniczek)
        {
            dzienniczek.Nazwa = "Dzienniczek Marcina";
        }

        static void InkrementacjaLiczba(out int liczba)
        {
            //W tym przypadku to zwiększenie bedzie tylko działało w tej metodzie. Ponieważ metoda wywoływana jest przez wartość a nie referencje czyli wskaźnik do obiektu.
            liczba = 42;
        }
        static void Main(string[] args)
        {
            //Refaktoryzacja kodu zaznaczamy wybrany kod i klikamy prawym klawiszem myszy - dajemy Quick Action i Extract Metod a następnie nazywamy metodę.
            //Należy odkometować aby użyć-  PrzekazywaniePrzezWartoscIRef();

            ImmutableMetoda();
        }

        private static void ImmutableMetoda()
        {
            string name = " Marcin ";
            //aby metoda Trim działała prawidłowo musimy przypisać efekt pracy do name i date.
            // Powstał nowy ciąg string.
            name = name.Trim();
            //Użycie konstruktora new z 3 parametrami
            DateTime date = new DateTime(2015,3,10);
            date = date.AddHours(48);
            DateTime date2 = new DateTime(2017, 3, 10);
            //przykład błedu początkującego programisty efekt pracy idzie w próżnie - zawsze musimy nowy obiekt przypisać do nowej zmiennej.
            date2.AddHours(72);
            Console.WriteLine(name);
            Console.WriteLine(date);
            Console.WriteLine(date2);
        }

        // Przykład metody która powstała z refaktoryzacji kodu.
        private static void PrzekazywaniePrzezWartoscIRef()
        {
            Dzienniczek dzienniczek1 = new Dzienniczek();
            //obie zmienne wskazuja na ten sam obiekt
            Dzienniczek dzienniczek2 = dzienniczek1;
            DajNazwe(dzienniczek2);
            Console.WriteLine(dzienniczek2.Nazwa);

            int x1;

            InkrementacjaLiczba(out x1);
            Console.WriteLine(x1);
        }
    }
}
