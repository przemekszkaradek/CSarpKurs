using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_12.Tablice
{
    class Dzienniczek
    {
        //Konstruktor domyślny tworzymy wpisując słowko ctor i dajemy 2 razy tab - używamy snipeta.
        // W konstruktorze ustawiamy wartości początkowe lub przekazujemy do niego jakieś wartości.
        public Dzienniczek()
        {
            oceny = new List<float>();
            Licznik++; // Licznik = Licznik + 1;
            Licznik2++;
        }


        // Stan zmienna pola -  Tworzymy nowy obiekt - Listę ocen - zostaje utworzony konstruktor domyślny za pomocą słówka new
        //List<float> oceny = new List<float>();
        private List<float> oceny;

        //Zmienne publiczne z dużej litery
        public string Nazwa;

        // Zachowania - metody
        /// <summary>
        /// Dodajemy ocenę.
        /// </summary>
        /// <param name="ocena">nowa ocena</param>  // definiujemy opis parametru
        public void DodajOcene(float ocena)
        {
            if (ocena >= 0 && ocena <= 10)
            {
                oceny.Add(ocena);
            }
        }
        /// <summary>
        /// Z tej metody dostajemy obiekt naszych statystyk
        /// </summary>
        /// <returns></returns>
        internal StatystykiDzienniczka CompletneStatystyki()
        {
            StatystykiDzienniczka statystyki = new StatystykiDzienniczka();

            float suma = 0f;
            foreach (var ocena in oceny)
            {
                suma = suma + ocena;
            }

            statystyki.sredniaOcena = suma / oceny.Count();
            statystyki.maxOcena = oceny.Max();
            statystyki.minimalnaOcena = oceny.Min();

            return statystyki;
        }

        //Pola statyczne - aby odwołać się do tych pól nie musimy tworzyć stancji klasy (obiektu). (dostępne na poziomie klasy)
        public static float MinimalnaOcena = 0;
        public static float MaksymalnaOcena = 10;
        //Count - licznik
        public static long Licznik = 0;
        //Pole dostępne na poziomie obiektu - zmienne nie statyczne.
        public long Licznik2 = 0;


        //Structs and Enums - Struktury i Wyliczenia
        //Do typu wyliczeniowego przypisyjemy nazwy - nie musimy pamiętać wartośći tylko posługujemy sie nazwą np.
        // Jeżeli nie podamy w kolejnych typach stawki edzie zwiekszana wartość o 1 czyli  Kontrakt = 1,  Etat = 2,
        //itd...
        public enum TypStawkiWynagrodzenia
        {
            Kontrakt = 1,
            Etat,
            Zlecenie,
            Godzinowa
        }
    }
}
