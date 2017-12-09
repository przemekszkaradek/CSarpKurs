using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Dzienniczek_Ucznia___Hermetyzacja
{
    class Dzienniczek
    {
        //Konstruktor domyślny tworzymy wpisując słowko ctor i dajemy 2 razy tab - używamy snipeta.
        // W konstruktorze ustawiamy wartości początkowe lub przekazujemy do niego jakieś wartości.
        public Dzienniczek()
        {
            oceny = new List<float>();
        }

     
        // Stan zmienna pola -  Tworzymy nowy obiekt - Listę ocen - zostaje utworzony konstruktor domyślny za pomocą słówka new
        //List<float> oceny = new List<float>();
        List<float> oceny;

        // Zachowania - metody
        /// <summary>
        /// Dodajemy ocenę.
        /// </summary>
        /// <param name="ocena">nowa ocena</param>  // definiujemy opis parametru
        public void DodajOcene(float ocena)
        {
            oceny.Add(ocena);
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

    }
}
