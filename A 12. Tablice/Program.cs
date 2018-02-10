using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_12.Tablice
{
    class Program
    {

        static void DajNazwe(Dzienniczek dzienniczek)
        {
            dzienniczek.Nazwa = "Dzienniczek Marcina";
        }

        static void InkrementacjaLiczba(out int liczba)
        {
            //W tym przypadku to zwiększenie bedzie tylko działało w tej metodzie. Ponieważ metoda wywoływana jest przez wartość a nie referencje czyli wskaźnik do obiektu.
            liczba = 42;
        }

        private static void ImmutableMetoda()
        {
            string name = " Marcin ";
            //aby metoda Trim działała prawidłowo musimy przypisać efekt pracy do name i date.
            // Powstał nowy ciąg string.
            name = name.Trim();
            //Użycie konstruktora new z 3 parametrami
            DateTime date = new DateTime(2015, 3, 10);
            date = date.AddHours(48);
            DateTime date2 = new DateTime(2017, 3, 10);
            //przykład błedu początkującego programisty efekt pracy idzie w próżnie - zawsze musimy nowy obiekt przypisać do nowej zmiennej.
            date2.AddHours(72);
            Console.WriteLine(name);
            Console.WriteLine(date);
            Console.WriteLine(date2);
        }

        static void Main(string[] args)
        {
            //Tablice

            //Tablica jest prostą kolekcją danych do zarządzania wielu obiektów lub wartości - typ referencyjny.
            //Tablice mają stały rozmiar kiedy tworzę tablicę muszę okreslić rozmiar - wielkosc. Czyli ile elemntów pomieści tablica. Listy są bardziej elastyczne bo wielkość listy zmienia się dynamicznie.
            // Tablice i Listy są ideksowane. Tablica index od 0. 

            //przykład z tablicą
            //stala - const
            const int numerStudentow = 5;
            int[] wyniki = new int[numerStudentow];

            int sumaWynikow = 0;
            foreach (var wynik in wyniki)
            {
                //sumowanie wynikow
                sumaWynikow += wynik;
            }
            //Wyliczamy srednia
            double sredniaWynikow = (double)sumaWynikow / wyniki.Length;


            TabliceMetoda();
        }

        private static void TabliceMetoda()
        {
            //deklaracja tablicy
            float[] oceny;
            //tworzymy tablice
            oceny = new float[4];
            // dodajemy oceny do tablicy - wielokość tablicy musi być z góry określona -  dodaje po indeksie.
            //oceny[0] = 4.2f;
            //oceny[1] = 6.7f;
            //oceny[2] = 3f;
            //oceny[3] = 8.5f;

            //metoda sluzaca do dowania ocen do nasze tablicy. Przykład referencji - tablica typ referencyjny.
            DodajOceny(oceny);
            // literujemy za pomoca petli po tablicy.
            foreach (var ocena in oceny)
            {
                Console.WriteLine(ocena);
            }
        }

        private static void DodajOceny(float[] oceny)
        {
           // sprawdzamy czy tablica ma  4 lub wiecej elementów 
            if (oceny.Length >= 4)
            {
                // po odkomentowaniu dostaniemy 4 zera ponieważ inizalizujemy dane do nowej tablicy.
                //oceny = new float[10]; 
                // dodajemy oceny do tablicy - wielokość tablicy musi być z góry określona -  dodaje po indeksie.
                oceny[0] = 4.2f;
                oceny[1] = 6.7f;
                oceny[2] = 3f;
                oceny[3] = 8.5f;
                //Odwolujemy sie do indexu który nie istnieje. (Wyjatek outAddRange) dlatego uzywamy lenght
                //oceny[4] = 4.4f;
            }

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
