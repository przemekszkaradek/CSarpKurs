using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A14.Typy
{

    //internal tylko w obrebie projektu.
    //zmieniamy na public
   public class Dzienniczek
    {
        public Dzienniczek()
        {
            oceny = new List<float>();

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
        public StatystykiDzienniczka CompletneStatystyki()
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
