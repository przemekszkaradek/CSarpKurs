using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A16.Pola_i_Wlasciwosci
{
    class Dzienniczek
    {
        public Dzienniczek()
        {
            oceny = new List<float>();
            //_nazwa = "Janek";
        }


        // Stan zmienna pola -  Tworzymy nowy obiekt - Listę ocen - zostaje utworzony konstruktor domyślny za pomocą słówka new
        //List<float> oceny = new List<float>();
        private List<float> oceny;

        //Automatyczna właściowść - kompilator za kulisami tworzy pole automatyczne.
        //public string Nazwa
        //{
        //    get; set;
        //}

        //dostepne tylko z klasy Dzienniczek
        private string _nazwa;
        //Zadziała poniższa logika biznesowa zostanie w programie jedynie wypisany dzienniczek Marcina null i pusty ciąg zostaną zignorowane.
        //Zeby można było pobrać wartości z pola stosujemy właściwości.
        public string Nazwa
        {
            get
            {
                //zwracamy dużymi literami.
                return _nazwa.ToUpper();
            }

            set
            {
                //Sprawdzamy czy ktoś coś podał - różny od nulla i pustego pola
                if(!string.IsNullOrEmpty(value))
                {
                    _nazwa = value;
                }
            }
        }

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
