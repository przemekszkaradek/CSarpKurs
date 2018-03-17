using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17.Delegaty
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
                    if(_nazwa != value)
                    {
                        //3.
                        //Wywołujemy nasze pole gdy nazwa się zmienia - Jeśli nazwa się zmienia to wywołujemy nasz delegat do którego przekazujemy 2 stringi nazwę którą chcemy zmienić oraz nową nazwę.
                        NazwaSieZmienia(_nazwa, value);
                    }
                    _nazwa = value;
                }
            }
        }
        //2.
        //Delegat - deklarujemy pole które jest typu naszego delegatu
        public NazwaSieZmieniaDelegate NazwaSieZmienia;

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
