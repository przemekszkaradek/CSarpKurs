using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Dzienniczek_Ucznia___z_konstruktorem
{
    class Dzienniczek
    {
        // Stan zmienna pola -  Tworzymy nowy obiekt - Listę ocen - zostaje utworzony konstruktor domyślny za pomocą słówka new
        List<float> oceny = new List<float>();

        // Zachowania - metody
        public void DodajOcene(float ocena)
        {
            oceny.Add(ocena);
        }

        public float ObliczanieSredniej()
        {
            float suma = 0, srednia = 0;
            foreach (var ocena in oceny)
            {
                suma = suma + ocena;
            }

            srednia = suma / oceny.Count();

            return srednia;
        }

        public float PobierzMaxOcene()
        {
            return oceny.Max();
        }

        public float PobierzMinimalnaOcene()
        {
            return oceny.Min();
        }
    }
}
