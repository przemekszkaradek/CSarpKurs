using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A25.Finalizacja_finally_
{
    class Dzienniczek
    {
        public Dzienniczek()
        {
            oceny = new List<float>();
            //_nazwa = "Janek";
        }

        private List<float> oceny;


        private string _nazwa;

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
                if (!string.IsNullOrEmpty(value))
                {
                    //Sprawdzamy czy nazwa jest rózna od wartości
                    //   if (_nazwa != value ) //zmienić do wyjątku
                    if (_nazwa != value && NazwaSieZmienia != null)
                    {
                        //4. Tworzymy instancję naszej klasy ZmienNazweEventArgs
                        ZmienNazweEventArgs args = new ZmienNazweEventArgs();
                        //Przypisujemy nazwę istniejącą oraz nową nazwę
                        args.IstniejacaNazwa = _nazwa;
                        args.NowaNazwa = value;

                        //zeby przekazać obiekt piszemy this oraz argumenty czyli args.
                        //this - wewnątrz kazdej nie statycznej metodzie, klasie lub strukurze c# znajduję się nie jawna zmienna this która odwołuje się do obiektu w którym jesteśmy czyli w tym wypadku do dzienniczka
                        //Jak sobie napiszemy this. to mamy dostęp do składowych dzienniczka (naszej klasy).
                        //Jest to zmienna którą można używać w dowolnym miejscu członka instancji jeśli chcesz odwołać się do siebie lub przekazać siebie jako inny parametr.
                        NazwaSieZmienia(this, args);
                    }
                    _nazwa = value;
                }
            }
        }
        //1. Aby dodać do delegata zdarzenie dodajemy słówko event
        public event NazwaSieZmieniaDelegate NazwaSieZmienia;

        public void DodajOcene(float ocena)
        {
            if (ocena >= 0 && ocena <= 10)
            {
                oceny.Add(ocena);
            }
        }

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
